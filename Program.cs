using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstDll;
using MySecondDll;

namespace CheckMyDll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            double result = AreasCalculate.SquareArea(x);

            double x1 = 10, x2 = 16.5;
            double result1 = AreasCalculate.RectangleArea(x1, x2);

            double y1 = 13.5, y2 = 4.5;
            double result2 = AreasCalculate.TriangleArea(y1, y2);

            Console.WriteLine($"Площади: \nКвадрата: {result}; \nПрямоугольника: {result1}; \nТреугольника: {result2}");

            string inputText = "A man, a plan, a canal, Panama!";

            Console.WriteLine($"Is Palindrome: {TextWork.IsPalindrome(inputText)}");
            Console.WriteLine($"Number of Sentences: {TextWork.CountSentences(inputText)}");
            Console.WriteLine($"Reversed Text: {TextWork.ReverseString(inputText)}");

            string validName = "JohnDoe";
            string invalidName = "123John";

            string validAge = "25";
            string invalidAge = "17";

            string validPhone = "+380630577445";
            string invalidPhone = "1234567890";

            string validEmail = "john.doe@example.com";
            string invalidEmail = "john.doe@.com";

            Console.WriteLine($"Name Validation: {ContactValidator.ValidateName(validName)}");
            Console.WriteLine($"Name Validation (Invalid): {ContactValidator.ValidateName(invalidName)}");

            Console.WriteLine($"Age Validation: {ContactValidator.ValidateAge(validAge)}");
            Console.WriteLine($"Age Validation (Invalid): {ContactValidator.ValidateAge(invalidAge)}");

            Console.WriteLine($"Phone Validation: {ContactValidator.ValidatePhone(validPhone)}");
            Console.WriteLine($"Phone Validation (Invalid): {ContactValidator.ValidatePhone(invalidPhone)}");

            Console.WriteLine($"Email Validation: {ContactValidator.ValidateEmail(validEmail)}");
            Console.WriteLine($"Email Validation (Invalid): {ContactValidator.ValidateEmail(invalidEmail)}");

            Console.ReadLine();

            //string sourceFilePath = "file.txt";
            //string destinationFilePath = "file1.txt";
            // FileManager.CopyFile(sourceFilePath, destinationFilePath);
            //Console.WriteLine($"File copied from '{sourceFilePath}' to '{destinationFilePath}'");

            //Console.WriteLine("Enter the first directory:");
            //string sourceDirPath = Console.ReadLine();
            //Console.WriteLine("Enter the second directory:");
            //string destinationDirPath = Console.ReadLine();
            //if (!string.IsNullOrEmpty(sourceDirPath) && !string.IsNullOrEmpty(destinationDirPath))
            //{
            //    FileManager.CopyDirectory(sourceDirPath, destinationDirPath);
            //    Console.WriteLine($"Directory copied from '{sourceDirPath}' to '{destinationDirPath}'");

            //    FileManager.DeleteFile(destinationFilePath);
            //    Console.WriteLine($"File deleted: '{destinationFilePath}'");
            //}

            //else 
            //{
            //    Console.WriteLine("The path is empty or uncorrect.");

            //}

            //string[] filesToDelete = { "file.txt", "file1.txt" };
            //FileManager.DeleteFiles(filesToDelete);
            //Console.WriteLine($"Files deleted: {string.Join(", ", filesToDelete)}");

            //FileManager.DeleteFilesByMask(sourceDirPath, "*.txt");
            //Console.WriteLine($"Files with '*.txt' extension deleted in '{sourceDirPath}'");

            //FileManager.MoveFile(sourceFilePath, destinationFilePath);
            //Console.WriteLine($"File moved from '{sourceFilePath}' to '{destinationFilePath}'");

            string sourceFilePath = "search_report.txt";
            string searchWord = "lorem";
            string reportFilePath = "report.txt";
            FileManager.SearchWordInFile(sourceFilePath, searchWord, reportFilePath);
            Console.WriteLine($"Search for '{searchWord}' in file completed. Report saved to {reportFilePath}");

            //FileManager.SearchWordInDirectory(sourceDirPath, searchWord, reportFilePath);
            //Console.WriteLine($"Search for '{searchWord}' in directory completed. Report saved to {reportFilePath}");

            Console.ReadLine();
        }
    }
}
