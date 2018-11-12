﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Nop.Core.Plugins;

namespace Nop.Data
{
    public partial interface IDbPlugin
    {
        void CheckModel(IDbPluginInstallModel model, ModelStateDictionary modelState);

        string CreateDatabase(string connectionString, string collation, int triesToConnect = 10);

        bool DatabaseExists(string connectionString);

        string DbConnectionInfo();

        string DbProvider();

        string GetConnectionString(IDbPluginInstallModel model);

        string DataProviderName { get; }
    }
}