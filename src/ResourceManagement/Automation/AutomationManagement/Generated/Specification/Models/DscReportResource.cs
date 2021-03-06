// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.Automation.Specification.Models;

namespace Microsoft.Azure.Management.Automation.Specification.Models
{
    /// <summary>
    /// Definition of the DSC Report Resource.
    /// </summary>
    public partial class DscReportResource
    {
        private IList<DscReportResourceNavigation> _dependsOn;
        
        /// <summary>
        /// Optional. Gets or sets the Resource Navigation values for resources
        /// the resource depends on.
        /// </summary>
        public IList<DscReportResourceNavigation> DependsOn
        {
            get { return this._dependsOn; }
            set { this._dependsOn = value; }
        }
        
        private double _durationInSeconds;
        
        /// <summary>
        /// Optional. Gets or sets the duration in seconds for the resource.
        /// </summary>
        public double DurationInSeconds
        {
            get { return this._durationInSeconds; }
            set { this._durationInSeconds = value; }
        }
        
        private string _error;
        
        /// <summary>
        /// Optional. Gets or sets the error of the resource.
        /// </summary>
        public string Error
        {
            get { return this._error; }
            set { this._error = value; }
        }
        
        private string _moduleName;
        
        /// <summary>
        /// Optional. Gets or sets the module name of the resource.
        /// </summary>
        public string ModuleName
        {
            get { return this._moduleName; }
            set { this._moduleName = value; }
        }
        
        private string _moduleVersion;
        
        /// <summary>
        /// Optional. Gets or sets the module version of the resource.
        /// </summary>
        public string ModuleVersion
        {
            get { return this._moduleVersion; }
            set { this._moduleVersion = value; }
        }
        
        private string _reportResourceId;
        
        /// <summary>
        /// Optional. Gets or sets the ID of the resource.
        /// </summary>
        public string ReportResourceId
        {
            get { return this._reportResourceId; }
            set { this._reportResourceId = value; }
        }
        
        private string _resourceName;
        
        /// <summary>
        /// Optional. Gets or sets the name of the resource.
        /// </summary>
        public string ResourceName
        {
            get { return this._resourceName; }
            set { this._resourceName = value; }
        }
        
        private string _sourceInfo;
        
        /// <summary>
        /// Optional. Gets or sets the source info of the resource.
        /// </summary>
        public string SourceInfo
        {
            get { return this._sourceInfo; }
            set { this._sourceInfo = value; }
        }
        
        private DateTimeOffset _startDate;
        
        /// <summary>
        /// Optional. Gets or sets the start date of the resource.
        /// </summary>
        public DateTimeOffset StartDate
        {
            get { return this._startDate; }
            set { this._startDate = value; }
        }
        
        private string _status;
        
        /// <summary>
        /// Optional. Gets or sets the status of the resource.
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DscReportResource class.
        /// </summary>
        public DscReportResource()
        {
            this.DependsOn = new LazyList<DscReportResourceNavigation>();
        }
    }
}
