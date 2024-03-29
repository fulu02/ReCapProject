﻿using Core.Results;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.Helpers
{
   
        public class FileHelper
        {

            private static string _currentDirectory = Environment.CurrentDirectory + "\\wwwroot";

            private static string _folderName = "\\images\\";

            public static IResult Add(IFormFile file)
            {
                var fileExists = CheckFile(file);
                if (fileExists.Message != null)
                {
                    return new ErrorResult(fileExists.Message);
                }

                var type = Path.GetExtension(file.FileName);

                var typeValid = CheckFileType(type);

                var randomName = Guid.NewGuid().ToString();

                if (typeValid.Message != null)
                {
                    return new ErrorResult(typeValid.Message);
                }

                CheckDirectory(_currentDirectory + _folderName);

                CreateImageFile(_currentDirectory + _folderName + randomName + type, file);

                return new SuccessResult((_folderName + randomName + type).Replace("\\", "/"));

            }

            public static IResult Update(IFormFile file, string imagePath)
            {
                var fileExists = CheckFile(file);

                if (fileExists.Message != null)
                {
                    return new ErrorResult(fileExists.Message);
                }

                var type = Path.GetExtension(file.FileName);

                var typeValid = CheckFileType(type);

                var randomName = Guid.NewGuid().ToString();

                if (typeValid.Message != null)
                {
                    return new ErrorResult(typeValid.Message);
                }

                DeleteOldImageFile((_currentDirectory + imagePath).Replace("/", "\\"));

                CheckDirectory(_currentDirectory + _folderName);

                CreateImageFile(_currentDirectory + _folderName + randomName + type, file);

                return new SuccessResult((_folderName + randomName + type).Replace("\\", "/"));
            }

            public static IResult Delete(string path)
            {
                DeleteOldImageFile((_currentDirectory + path).Replace("/", "\\"));
                return new SuccessResult();
            }




            private static IResult CheckFile(IFormFile file)
            {
                if (file != null && file.Length > 0)
                {
                    return new SuccessResult();
                }
                return new ErrorResult("Dosya mevcut değil.");
            }


            private static IResult CheckFileType(string type)
            {
                if (type != ".jpeg" && type != ".png" && type != ".jpg")
                {
                    return new ErrorResult("Yanlış dosya türü.");
                }
                return new SuccessResult();
            }

            private static void CheckDirectory(string directory)
            {
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
            }
            private static void CreateImageFile(string directory, IFormFile file)
            {
                using (FileStream fileStream = File.Create(directory))
                {
                    file.CopyTo(fileStream);

                    fileStream.Flush();
                }
            }
        }
    }
