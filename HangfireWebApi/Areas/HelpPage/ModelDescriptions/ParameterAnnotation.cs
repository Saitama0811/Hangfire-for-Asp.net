using System;

namespace HangfireWebApi.Areas.HelpPage.ModelDescriptions
{
    public class ParameterAnnotation
    {
        public Attribute AnnotationAttribute { get; set; }

        public string Documentation { get; set; }
    }
}