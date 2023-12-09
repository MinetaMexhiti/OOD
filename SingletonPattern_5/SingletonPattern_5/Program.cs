using System;
using SingletonPattern_5;

class Program
{
    static void Main (string[] args)
    {
        Logger logger = Logger.Inst;


        logger.Log("Application started.");
        logger.Log("Performing some operations...");


        logger.Log("Application end . ");

        logger.Dispose();
             
    }
}