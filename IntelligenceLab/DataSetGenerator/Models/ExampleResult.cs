﻿using System.Collections.Generic;

namespace DataSetGenerator.Models
{
    public class ExampleResult
    {
        public ExampleResult()
        {
            LearningSet = new HashSet<Example>();
            ControlSet = new HashSet<Example>();
        }

        public ISet<Example> LearningSet { get; set; }

        public ISet<Example> ControlSet { get; set; }
    }
}
