//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// <copyright>
// Copyright by the Spark Development Network
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
using System;
using System.Collections.Generic;


namespace Rock.Client
{
    /// <summary>
    /// Base client model for AnalyticsDimFinancialAccount that only includes the non-virtual fields. Use this for PUT/POSTs
    /// </summary>
    public partial class AnalyticsDimFinancialAccountEntity
    {
        /// <summary />
        public int Id { get; set; }

        /// <summary />
        public int AccountId { get; set; }

        /// <summary />
        public string AccountType { get; set; }

        /// <summary />
        public string ActiveStatus { get; set; }

        /// <summary />
        public string CampusName { get; set; }

        /// <summary />
        public string CampusShortCode { get; set; }

        /// <summary />
        public string Description { get; set; }

        /// <summary />
        public DateTime? EndDate { get; set; }

        /// <summary />
        public Guid? ForeignGuid { get; set; }

        /// <summary />
        public string ForeignKey { get; set; }

        /// <summary />
        public string GlCode { get; set; }

        /// <summary />
        public int? ImageBinaryFileId { get; set; }

        /// <summary />
        public string ImageUrl { get; set; }

        /// <summary />
        public string Name { get; set; }

        /// <summary />
        public int Order { get; set; }

        /// <summary />
        public int? ParentAccountId { get; set; }

        /// <summary />
        public string PublicDescription { get; set; }

        /// <summary />
        public string PublicName { get; set; }

        /// <summary />
        public string PublicStatus { get; set; }

        /// <summary />
        public DateTime? StartDate { get; set; }

        /// <summary />
        public string TaxStatus { get; set; }

        /// <summary />
        public string Url { get; set; }

        /// <summary />
        public Guid Guid { get; set; }

        /// <summary />
        public int? ForeignId { get; set; }

        /// <summary>
        /// Copies the base properties from a source AnalyticsDimFinancialAccount object
        /// </summary>
        /// <param name="source">The source.</param>
        public void CopyPropertiesFrom( AnalyticsDimFinancialAccount source )
        {
            this.Id = source.Id;
            this.AccountId = source.AccountId;
            this.AccountType = source.AccountType;
            this.ActiveStatus = source.ActiveStatus;
            this.CampusName = source.CampusName;
            this.CampusShortCode = source.CampusShortCode;
            this.Description = source.Description;
            this.EndDate = source.EndDate;
            this.ForeignGuid = source.ForeignGuid;
            this.ForeignKey = source.ForeignKey;
            this.GlCode = source.GlCode;
            this.ImageBinaryFileId = source.ImageBinaryFileId;
            this.ImageUrl = source.ImageUrl;
            this.Name = source.Name;
            this.Order = source.Order;
            this.ParentAccountId = source.ParentAccountId;
            this.PublicDescription = source.PublicDescription;
            this.PublicName = source.PublicName;
            this.PublicStatus = source.PublicStatus;
            this.StartDate = source.StartDate;
            this.TaxStatus = source.TaxStatus;
            this.Url = source.Url;
            this.Guid = source.Guid;
            this.ForeignId = source.ForeignId;

        }
    }

    /// <summary>
    /// Client model for AnalyticsDimFinancialAccount that includes all the fields that are available for GETs. Use this for GETs (use AnalyticsDimFinancialAccountEntity for POST/PUTs)
    /// </summary>
    public partial class AnalyticsDimFinancialAccount : AnalyticsDimFinancialAccountEntity
    {
    }
}