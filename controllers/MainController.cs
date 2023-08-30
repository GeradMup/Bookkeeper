﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invoices.src.models;
using Invoices.src.views;

namespace Invoices.src.controllers
{
    /// <summary>
    /// The main controller for running the main startups of all objects needed
    /// </summary>
    public partial class MainController
    {
        MainWindow mainWindow;
        InvoiceController invoiceController;
        InvoiceModel invoiceModel;
        ClientsModel clientsModel;
        ClientsController clientsController;
        SetupModel setupModel;
        SetupController setupController;
        HistoryController historyController;
        HistoryModel historyModel;

        public MainController() 
        {
            //Create a new instance of the new main window.
            mainWindow = new MainWindow();
            invoiceModel = new InvoiceModel();
            invoiceController = new InvoiceController(mainWindow, invoiceModel);
            clientsModel = new ClientsModel();
            clientsController = new ClientsController(clientsModel, mainWindow, invoiceController.getCallBack());
            setupModel = new SetupModel();
            setupController = new SetupController(setupModel, mainWindow);
            historyModel = new HistoryModel();
            historyController = new HistoryController(mainWindow, historyModel);

            //invoiceController.initializeInvoice();
            //Assign controllers to the relevant views
            
        }

        //Returns the created instance of mainWindow
        public MainWindow GetWindow() { return mainWindow; }

    }

    





}
