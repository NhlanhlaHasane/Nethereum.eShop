﻿using System;
using System.Text;

using Nethereum.eShop.ApplicationCore.Entities.RulesEngine;

namespace Nethereum.eShop.ApplicationCore.Exceptions
{
    public class RuleTreeException : Exception
    {
        public RuleTreeException(StringBuilder ruleTreeId) : base($"No ruletree found with id {ruleTreeId.ToString()}")
        {
        }

        protected RuleTreeException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }

        public RuleTreeException(string message) : base(message)
        {
        }

        public RuleTreeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public RuleTreeException(string message, RuleTreeSeed failedTree, RuleTreeReport failedReport = null) : base(message)
        {
            FailedRuleTree       = failedTree;
            FailedRuleTreeReport = failedReport;
        }

        public RuleTreeException(string message, Exception innerException, RuleTreeSeed failedTree, RuleTreeReport failedReport = null) : base(message, innerException)
        {
            FailedRuleTree       = failedTree;
            FailedRuleTreeReport = failedReport;
        }

        public RuleTreeException(RuleTreeSeed failedTree, RuleTreeReport failedReport = null)
        {
            FailedRuleTree       = failedTree;
            FailedRuleTreeReport = failedReport;
        }

        #region Properties

        public RuleTreeSeed FailedRuleTree { get; protected set; }

        public RuleTreeReport FailedRuleTreeReport { get; protected set; }

        #endregion

    }
}
