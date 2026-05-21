using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Application.ApplicationConstants
{
    public class ApplicationConstants
    {
    }

    public class CommonMessage
    {
        public const string CreateOperationSuccess = "Created successfully.";
        public const string UpdateOperationSuccess = "Updated successfully.";
        public const string DeleteOperationSuccess = "Deleted successfully.";

        public const string CreateOperationFailed = "Created Operation Failed.";
        public const string UpdateOperationFailed = "Updated Operation Failed.";
        public const string DeleteOperationFailed = "Deleted Operation Failed.";

        public const string RecordNotFound = "Record Not Found.";
        public const string SystemError = "Something went wrong.";

        public const string CategoryNotFound = "Category not found.";
        public const string CategoryAlreadyExists = "Category with the same name already exists.";
        public const string ProductNotFound = "Product not found.";
        public const string ProductAlreadyExists = "Product with the same name already exists.";
    }
}
