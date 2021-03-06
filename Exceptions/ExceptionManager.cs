﻿using System;
using System.Collections.Generic;
using System.IO;
using DataAccess.Crud;
using Entities;

namespace Exceptions
{
    public class ExceptionManager
    {
        private static ExceptionManager instance;

        private static readonly Dictionary<int, ApplicationMessage>
            messages = new Dictionary<int, ApplicationMessage>();

        public string PATH = @"C:\temp\logs\";

        private ExceptionManager()
        {
            LoadMessages();
        }

        public static ExceptionManager GetInstance()
        {
            if (instance == null)
                instance = new ExceptionManager();
            return instance;
        }

        public void Process(Exception ex)
        {
            var bex = new BusinessException();
            if (ex.GetType() == typeof(BusinessException))
                bex = (BusinessException) ex;
            else
                bex = new BusinessException(0, ex);


            ProcessBusinessException(bex);
        }

        private void ProcessBusinessException(BusinessException bex)
        {
            var today = DateTime.Now.ToString("yyyy-MM-dd");
            var logName = PATH + today + "_" + "log.txt";
            var message = bex.Message + "\n" + bex.StackTrace + "\n";

            if (bex.InnerException != null)
                message += bex.InnerException.Message + "\n" + bex.InnerException.StackTrace;

            using (var w = File.AppendText(logName))
            {
                Log(bex.Message, w);
            }

            bex.AppMessage = GetMessage(bex);
            throw bex;
        }

        private void LoadMessages()
        {
            var crudMessages = new AppMessagesCrudFactory();
            var lstMessages = crudMessages.RetrieveAll<ApplicationMessage>();
            foreach (var appMessage in lstMessages) messages.Add(appMessage.ID, appMessage);
        }

        public ApplicationMessage GetMessage(BusinessException bex)
        {
            var appMessage = new ApplicationMessage();
            appMessage.Message = "Message not found";
            if (messages.ContainsKey(bex.ExceptionID))
                appMessage = messages[bex.ExceptionID];
            return appMessage;
        }

        private void Log(string logMessage, TextWriter w)
        {
            w.Write("\r\nLog Entry: ");
            w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            w.WriteLine("  :");
            w.WriteLine("  :{0}", logMessage);
            w.WriteLine("-------------------------------");
        }
    }
}