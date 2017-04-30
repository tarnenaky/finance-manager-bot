﻿using System.Collections.Generic;
using FinanceManager.Bot.Framework.Enums;
using FinanceManager.Bot.Framework.Results;

namespace FinanceManager.Bot.Framework.Services
{
    public class ResultService
    {
        public HandlerServiceResult BuildNotUniqueCategoryNameErrorResult()
        {
            return new HandlerServiceResult
            {
                Message = "Sorry, name should be unique.",
                StatusCode = StatusCodeEnum.Bad
            };
        }

        public HandlerServiceResult BuildLongCategoryNameErrorResult()
        {
            return new HandlerServiceResult
            {
                Message = "Sorry, you cannot type more than 30 symbols",
                StatusCode = StatusCodeEnum.Bad
            };
        }

        public HandlerServiceResult BuildClearCategoryNameErrorResult()
        {
            return new HandlerServiceResult
            {
                Message = "Sorry, you should type something",
                StatusCode = StatusCodeEnum.Bad
            };
        }

        public HandlerServiceResult BuildCategoryActionsResult()
        {
            return new HandlerServiceResult
            {
                Message = "You always can create, edit or delete categories by /category command",
                StatusCode = StatusCodeEnum.Ok
            };
        }

        public HandlerServiceResult BuildYouShouldTypeOnlyYesOrNoErrorResult()
        {
            return new HandlerServiceResult
            {
                Message = "Sorry, you can type only Yes or No, or you can /cancel command.",
                Helper = new List<string>
                {
                    "Yes",
                    "No"
                },
                StatusCode = StatusCodeEnum.NeedKeyboard
            };
        }

        public HandlerServiceResult BuildCategoryNotFoundErrorResult()
        {
            return new HandlerServiceResult
            {
                Message = "Sorry, you don't have any category with this name.",
                StatusCode = StatusCodeEnum.Ok
            };
        }

        public HandlerServiceResult BuildCategoryDeletedResult()
        {
            return new HandlerServiceResult
            {
                Message = "Category was deleted successfully.",
                StatusCode = StatusCodeEnum.Ok
            };
        }

        public HandlerServiceResult BuildCategoryActionWrongAnswerErrorResult()
        {
            return new HandlerServiceResult
            {
                Helper = new List<string>
                {
                    "Add new category",
                    "Edit category",
                    "Delete category"
                },
                Message = "Sorry, you should chose one of three options, or you can /cancel command.",
                StatusCode = StatusCodeEnum.NeedKeyboard
            };
        }

        public HandlerServiceResult BuildOperationInvalidDateErrorResult()
        {
            return new HandlerServiceResult
            {
                Message = "Please, enter a valid date.",
                StatusCode = StatusCodeEnum.Bad
            };
        }

        public HandlerServiceResult BuildOperationCategoryNotFoundErrorResult()
        {
            return new HandlerServiceResult
            {
                Message = "Category with this name not found.",
                StatusCode = StatusCodeEnum.Bad
            };
        }

        public HandlerServiceResult BuildEmptyAnswerErrorResult()
        {
            return new HandlerServiceResult
            {
                Message = "You should type something.",
                StatusCode = StatusCodeEnum.Bad
            };
        }

        public HandlerServiceResult BuildFinishedConfiguringResult()
        {
            return new HandlerServiceResult
            {
                Message = "Well done!",
                StatusCode = StatusCodeEnum.Ok
            };
        }

        public HandlerServiceResult BuildOperationInvalidSumErrorResult()
        {
            return new HandlerServiceResult
            {
                Message = "Invalid sum. Please, try again.",
                StatusCode = StatusCodeEnum.Bad
            };
        }

        public HandlerServiceResult BuildOperationInvalidTypeErrorResult()
        {
            return new HandlerServiceResult
            {
                Message = "You should type + or -",
                StatusCode = StatusCodeEnum.Bad
            };
        }

        public HandlerServiceResult BuildOperationTypeCleanCategoryList()
        {
            return new HandlerServiceResult
            {
                Message = "Sorry, there are no categories with this type.",
                StatusCode = StatusCodeEnum.Bad
            };
        }

        public HandlerServiceResult BuildErrorResult()
        {
            return new HandlerServiceResult
            {
                Message = "Sorry, something went wrong. Please, try /cancel the command and start again.",
                StatusCode = StatusCodeEnum.Bad
            };
        }

        public HandlerServiceResult BuildOperationExceededAmountForThisMonth(float difference)
        {
            return new HandlerServiceResult
            {
                Message = string.Format("You have exceeded the expected amount for this month by {0}", difference),
                StatusCode = StatusCodeEnum.Ok
            };
        }
    }
}