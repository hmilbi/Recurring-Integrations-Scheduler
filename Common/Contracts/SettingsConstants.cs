﻿/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

namespace RecurringIntegrationsScheduler.Common.Contracts
{
    /// <summary>
    /// Constants strings used in job map object
    /// </summary>
    public static class SettingsConstants
    {
        /// <summary>
        /// The AOS URI
        /// </summary>
        public const string AosUri = "AosUri";

        /// <summary>
        /// Azure authentication endpoint
        /// </summary>
        public const string AzureAuthEndpoint = "AzureAuthEndpoint";

        /// <summary>
        /// Azure Active Directory tenant Id
        /// </summary>
        public const string AadTenant = "AadTenant";

        /// <summary>
        /// Is ADAL used for authentication
        /// </summary>
        public const string UseADAL = "UseADAL";

        /// <summary>
        /// Is service authentication used
        /// </summary>
        public const string UseServiceAuthentication = "UseServiceAuthentication";

        /// <summary>
        /// Azure Active Directory client identifier
        /// </summary>
        public const string AadClientId = "AadClientId";

        /// <summary>
        /// Azure Active Directory client secret
        /// </summary>
        public const string AadClientSecret = "AadClientSecret";

        /// <summary>
        /// User name
        /// </summary>
        public const string UserName = "UserName";

        /// <summary>
        /// User password
        /// </summary>
        public const string UserPassword = "UserPassword";

        /// <summary>
        /// The activity identifier
        /// </summary>
        public const string ActivityId = "ActivityId";

        /// <summary>
        /// The delay between files processing
        /// </summary>
        public const string DelayBetweenFiles = "DelayBetweenFiles";

        /// <summary>
        /// The delay between status check of export job
        /// </summary>
        public const string DelayBetweenStatusCheck = "DelayBetweenStatusCheck";

        /// <summary>
        /// The retry count
        /// </summary>
        public const string RetryCount = "RetryCount";

        /// <summary>
        /// The retry delay
        /// </summary>
        public const string RetryDelay = "RetryDelay";

        /// <summary>
        /// Pause job in case of exception
        /// </summary>
        public const string PauseJobOnException = "PauseJobOnException";

        /// <summary>
        /// Pause job indefinitely
        /// </summary>
        public const string IndefinitePause = "IndefinitePause";

        /// <summary>
        /// The relative path to the ImportFromPackage Odata action
        /// </summary>
        public const string ImportFromPackageActionPath = "ImportFromPackageActionPath";

        /// <summary>
        /// The relative path to the GetAzureWriteUrl Odata action
        /// </summary>
        public const string GetAzureWriteUrlActionPath = "GetAzureWriteUrlActionPath";

        /// <summary>
        /// The relative path to the GetExecutionSummaryStatus Odata action
        /// </summary>
        public const string GetExecutionSummaryStatusActionPath = "GetExecutionSummaryStatusActionPath";

        /// <summary>
        /// The relative path to the GetExportedPackageUrl Odata action
        /// </summary>
        public const string GetExportedPackageUrlActionPath = "GetExportedPackageUrlActionPath";

        /// <summary>
        /// The relative path to the GetExecutionSummaryPageUrl Odata action
        /// </summary>
        public const string GetExecutionSummaryPageUrlActionPath = "GetExecutionSummaryPageUrlActionPath";

        /// <summary>
        /// The relative path to the DeleteExecutionHistoryJob Odata action
        /// </summary>
        public const string DeleteExecutionHistoryJobActionPath = "DeleteExecutionHistoryJobActionPath";

        /// <summary>
        /// The relative path to the ExportToPackage Odata action
        /// </summary>
        public const string ExportToPackageActionPath = "ExportToPackageActionPath";

        /// <summary>
        /// The relative path to the ExportFromPackage Odata action
        /// </summary>
        public const string ExportFromPackageActionPath = "ExportFromPackageActionPath";

        /// <summary>
        /// The relative path to the GetMessageStatus Odata action
        /// </summary>
        public const string GetMessageStatusActionPath = "GetMessageStatusActionPath";

        /// <summary>
        /// The relative path to the GenerateImportTargetErrorKeysFile Odata action
        /// </summary>
        public const string GenerateImportTargetErrorKeysFilePath = "GenerateImportTargetErrorKeysFilePath";

        /// <summary>
        /// The relative path to the GetImportTargetErrorKeysFileUrl Odata action
        /// </summary>
        public const string GetImportTargetErrorKeysFileUrlPath = "GetImportTargetErrorKeysFileUrlPath";

        /// <summary>
        /// The relative path to the GetExecutionErrors Odata action
        /// </summary>
        public const string GetExecutionErrorsPath = "GetExecutionErrorsPath";

        /// <summary>
        /// The download job
        /// </summary>
        public const string DownloadJob = "RecurringIntegrationsScheduler.Job.Download";

        /// <summary>
        /// The upload job
        /// </summary>
        public const string UploadJob = "RecurringIntegrationsScheduler.Job.Upload";

        /// <summary>
        /// The processing job
        /// </summary>
        public const string ProcessingJob = "RecurringIntegrationsScheduler.Job.ProcessingMonitor";

        /// <summary>
        /// The import job
        /// </summary>
        public const string ImportJob = "RecurringIntegrationsScheduler.Job.Import";

        /// <summary>
        /// The export job
        /// </summary>
        public const string ExportJob = "RecurringIntegrationsScheduler.Job.Export";

        /// <summary>
        /// The execution monitor job
        /// </summary>
        public const string ExecutionJob = "RecurringIntegrationsScheduler.Job.ExecutionMonitor";

        /// <summary>
        /// Input folder
        /// </summary>
        public const string InputDir = "InputDir";

        /// <summary>
        /// Upload success folder
        /// </summary>
        public const string UploadSuccessDir = "UploadSuccessDir";

        /// <summary>
        /// Upload errors folder
        /// </summary>
        public const string UploadErrorsDir = "UploadErrorsDir";

        /// <summary>
        /// The entity name
        /// </summary>
        public const string EntityName = "EntityName";

        /// <summary>
        /// Is it data package
        /// </summary>
        public const string IsDataPackage = "IsDataPackage";

        /// <summary>
        /// The company
        /// </summary>
        public const string Company = "Company";

        /// <summary>
        /// The status file extension
        /// </summary>
        public const string StatusFileExtension = "StatusFileExtension";

        /// <summary>
        /// Is processing job present
        /// </summary>
        public const string ProcessingJobPresent = "ProcessingJobPresent";

        /// <summary>
        /// The search pattern
        /// </summary>
        public const string SearchPattern = "SearchPattern";

        /// <summary>
        /// Order by
        /// </summary>
        public const string OrderBy = "OrderBy";

        /// <summary>
        /// Reverse order
        /// </summary>
        public const string ReverseOrder = "ReverseOrder";

        /// <summary>
        /// Processing success folder
        /// </summary>
        public const string ProcessingSuccessDir = "ProcessingSuccessDir";

        /// <summary>
        /// Processing errors folder
        /// </summary>
        public const string ProcessingErrorsDir = "ProcessingErrorsDir";

        /// <summary>
        /// Download success folder
        /// </summary>
        public const string DownloadSuccessDir = "DownloadSuccessDir";

        /// <summary>
        /// Download errors folder
        /// </summary>
        public const string DownloadErrorsDir = "DownloadErrorsDir";

        /// <summary>
        /// Unzip package
        /// </summary>
        public const string UnzipPackage = "UnzipPackage";

        /// <summary>
        /// Add timestamp to file
        /// </summary>
        public const string AddTimestamp = "AddTimestamp";

        /// <summary>
        /// Delete package archive
        /// </summary>
        public const string DeletePackage = "DeletePackage";

        /// <summary>
        /// Upload in order
        /// </summary>
        public const string UploadInOrder = "UploadInOrder";

        /// <summary>
        /// Is execution job present
        /// </summary>
        public const string ExecutionJobPresent = "ExecutionJobPresent";

        /// <summary>
        /// Data project
        /// </summary>
        public const string DataProject = "DataProject";

        /// <summary>
        /// Overwrite data project
        /// </summary>
        public const string OverwriteDataProject = "OverwriteDataProject";

        /// <summary>
        /// Execute import
        /// </summary>
        public const string ExecuteImport = "ExecuteImport";

        /// <summary>
        /// Package template
        /// </summary>
        public const string PackageTemplate = "PackageTemplate";

        /// <summary>
        /// Get import target error keys file
        /// </summary>
        public const string GetImportTargetErrorKeysFile = "GetImportTargetErrorKeysFile";

        /// <summary>
        /// Multicompany import
        /// </summary>
        public const string MultiCompanyImport = "MultiCompanyImport";

        /// <summary>
        /// Get legal entity from filename
        /// </summary>
        public const string GetLegalEntityFromFilename = "GetLegalEntityFromFilename";

        /// <summary>
        /// Get legal entity from subfolder
        /// </summary>
        public const string GetLegalEntityFromSubfolder = "GetLegalEntityFromSubfolder";

        /// <summary>
        /// Filename separator
        /// </summary>
        public const string FilenameSeparator = "FilenameSeparator";

        /// <summary>
        /// Legal entity token position
        /// </summary>
        public const string LegalEntityTokenPosition = "LegalEntityTokenPosition";

        /// <summary>
        /// Input files are packages
        /// </summary>
        public const string InputFilesArePackages = "InputFilesArePackages";

        /// <summary>
        /// Get execution errors
        /// </summary>
        public const string GetExecutionErrors = "GetExecutionErrors";

        /// <summary>
        /// Log verbose
        /// </summary>
        public const string LogVerbose = "LogVerbose";

        /// <summary>
        /// Daily log
        /// </summary>
        public const string CreateDailyLog_BEC = "CreateDailyLog_BEC";

        /// <summary>
        /// Job key
        /// </summary>
        public const string JobKey = "JobKey";
    }
}