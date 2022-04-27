using System;using R5T.T0064;


namespace R5T.Troy
{[ServiceDefinitionMarker]
    public interface ITemporaryDirectoryNameConvention:IServiceDefinition
    {
        string GetTemporaryDirectoryName();
    }
}
