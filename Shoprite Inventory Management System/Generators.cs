﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarcodeLib;
using System.Drawing;
using System.Drawing.Imaging;
using BarcodeLib.BarcodeReader;
using System.IO;
//using PQScan.BarcodeCreator;


namespace Shoprite_Inventory_Management_System
{
    internal class Generators
    {



        public Generators()
        {

        }
        public string randomPassword(int length)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringPassword = new char[length];
            var random = new Random();

            for (int index = 0; index < stringPassword.Length; index++)
            {
                stringPassword[index] = chars[random.Next(chars.Length)];
            }

            return new string(stringPassword);
        }

        public string randomPincode(int length)
        {
            var chars = "0123456789";
            var stringPassword = new char[length];
            var random = new Random();

            for (int index = 0; index < stringPassword.Length; index++)
            {
                stringPassword[index] = chars[random.Next(chars.Length)];
            }

            return new string(stringPassword);
        }

        public string randomProductcode(int length)
        {
            var chars = "0123456789";
            var productPassword = new char[length];
            var random = new Random();

            for (int index = 0; index < productPassword.Length; index++)
            {
                productPassword[index] = chars[random.Next(chars.Length)];
            }

            return new string(productPassword);
        }


        public void barcodeGenerator()
        {

            Barcode barcodelib = new Barcode();

            int imgageHeight = 110;
            int imageWidth = 250;

            Color foreColor = Color.Black;
            Color backColor = Color.Transparent;

            //string alphaNumeric = string.Format("{0}",randomProductcode(10));
             string numeric = ""+randomProductcode(12)+"";
            ///string numer = randomProductcode(11);
            //string numeric = "012345678901";

            Image barcodeImage = barcodelib.Encode(TYPE.UPCA, numeric, foreColor, backColor, imageWidth, imgageHeight);

            //barcodeImage.Save(@"C:\\Users\BrandedHustler\Barcode.png", ImageFormat.Png);
            //barcodeImage.Save(string.Format(@"C:\{}",alphaNumeric), ImageFormat.Png);
            barcodeImage.Save(@"C:\\Users\BrandedHustler\"+numeric+".png", ImageFormat.Png);
        }

        public void barcodeGenerators()
        {
            Barcode barcodelib = new Barcode();

            int imgageHeight = 110;
            int imageWidth = 250;

            Color foreColor = Color.Black;
            Color backColor = Color.Transparent;

            string numeric = "123456789012";
            Image barcodeImage = barcodelib.Encode(TYPE.UPCA, numeric, foreColor, backColor, imageWidth, imgageHeight);
            using (MemoryStream ms = new MemoryStream())
            {
                barcodeImage.Save(ms, ImageFormat.Png);
            }
        }
        public void barcodeReader()
        {
           // name = randomProductcode(12);
           // string[] BarcodeUPCA = BarcodeReader.read(@"C:\"+name+".png", BarcodeReader.UPCA);
            string[] BarcodeUPCA = BarcodeReader.read(@"C:\\Users\BrandedHustler\Barcode.png", BarcodeReader.UPCA);
            ConvertStringArrayToString(BarcodeUPCA);
        }

        public string ConvertStringArrayToString(string[] array)
        {
            // Concatenate all the elements into a StringBuilder.
            StringBuilder builder = new StringBuilder();
            foreach (string value in array)
            {
                builder.Append(value);

            }
            return builder.ToString();
        }
    }
}
