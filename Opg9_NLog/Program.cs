﻿using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg9_NLog
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();


        static void Main(string[] args)
        {
            logger.Trace("Enter");
            logger.Debug("Nu kaldes test1");
            test1(5, 5);
            logger.Debug("Retur fra test1");
            logger.Trace("Enter");
            logger.Debug("Nu kaldes test2");
            test2();
            logger.Debug("Retur fra test2");
            logger.Trace("Exit");
        }


      


        static void test1(int i, int x)
        {
            Console.WriteLine("test1");
            System.Threading.Thread.Sleep(3000);
        }

        static void test2()
        {
            try
            {
                Console.WriteLine("test2");
                throw new ApplicationException("fejl");
            }
            catch (Exception ex)
            {
                // mangler log
                logger.Error(ex);
                
            }
        }
    }
}

