﻿using Gravitybox.gFileSystem.Service.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Gravitybox.gFileSystem.Manager
{
    internal static class Extensions
    {
        public static byte[] Encrypt(this byte[] src, byte[] masterKey, byte[] iv)
        {
            try
            {
                var aes = CryptoProvider(masterKey, iv);
                using (ICryptoTransform encrypt = aes.CreateEncryptor())
                {
                    byte[] dest = encrypt.TransformFinalBlock(src, 0, src.Length);
                    return dest;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static byte[] Decrypt(this byte[] src, byte[] masterKey, byte[] iv)
        {
            try
            {
                var aes = CryptoProvider(masterKey, iv);
                using (ICryptoTransform decrypt = aes.CreateDecryptor())
                {
                    byte[] dest = decrypt.TransformFinalBlock(src, 0, src.Length);
                    return dest;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private static AesCryptoServiceProvider CryptoProvider(byte[] key, byte[] iv)
        {
            var aes = new AesCryptoServiceProvider();
            aes.IV = iv;
            aes.Key = key;
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;
            return aes;
        }

        internal static void EncryptStream(this System.IO.Stream stream, string targetFile, byte[] iv, FileHeader header)
        {
            try
            {
                var aes = CryptoProvider(header.DataKey, iv);
                using (ICryptoTransform encryptor = aes.CreateEncryptor())
                {
                    using (var newFile = File.Create(targetFile))
                    {
                        //Write blank header. It will be filled in later
                        var padBytes = new byte[FileHeader.FileHeaderSize];
                        newFile.Write(padBytes, 0, padBytes.Length);

                        //Write encrypted data
                        using (var cryptoStream = new CryptoStream(newFile, encryptor, CryptoStreamMode.Write))
                        {
                            stream.CopyTo(cryptoStream);
                        }
                    }
                }
                WriteFileHeader(targetFile, header);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        internal static void DecryptStream(this System.IO.Stream src, System.IO.Stream dest, byte[] iv, FileHeader header)
        {
            try
            {
                //Get the data key
                var vv = new byte[FileHeader.FileHeaderSize];
                src.Read(vv, 0, vv.Length);
                header.Load(vv);

                header.DataKey = header.EncryptedDataKey.Decrypt(header.TenantKey, iv);

                var aes = CryptoProvider(header.DataKey, iv);
                using (ICryptoTransform encryptor = aes.CreateDecryptor())
                {
                    src.Seek(FileHeader.FileHeaderSize, SeekOrigin.Begin);
                    using (var cryptoStream = new CryptoStream(src, encryptor, CryptoStreamMode.Read))
                    {
                        cryptoStream.CopyTo(dest);
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        internal static void WriteFileHeader(string cryptFileName, FileHeader header)
        {
            try
            {
                using (var file = File.OpenWrite(cryptFileName))
                {
                    //Write encrypted data key to front of file
                    var padBytes = header.ToArray();
                    file.Write(padBytes, 0, padBytes.Length);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                throw;
            }
        }

    }

}