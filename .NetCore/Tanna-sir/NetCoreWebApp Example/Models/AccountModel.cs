using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using System.ComponentModel.DataAnnotations;

namespace NetCoreWebApp_Example.Models
{
    public class AccountModel
    {
        //        CREATE TABLE[dbo].[Account]
        //        (
        //    [savingsActNo] INT          NOT NULL,
        //    [actHolderName] VARCHAR(50) NULL,
        //    [profession] VARCHAR(50) NULL,
        //    [Email] VARCHAR(50) NULL,
        //    [ContactNo] VARCHAR(50) NULL,
        //    PRIMARY KEY CLUSTERED([savingsActNo] ASC)
        //);

        [Key]
        public int savingsActNo { get; set; }
        public string actHolderName { get; set; }
        public string profession {  get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }

    }
}
