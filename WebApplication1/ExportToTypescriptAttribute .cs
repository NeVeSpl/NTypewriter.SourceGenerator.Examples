namespace WebApplication1
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum)]
    internal sealed class ExportToTypescriptAttribute : Attribute
    {
        public string OutputPath { get; }

        public ExportToTypescriptAttribute(string OutputPath)
        {
            this.OutputPath = OutputPath;
        }
    }
}
