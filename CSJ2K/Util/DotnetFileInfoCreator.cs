﻿namespace CSJ2K.Util
{
#if NETFX_CORE
	[System.Composition.Export(typeof(IFileInfoCreator))]
#elif !DOTNET
	[System.ComponentModel.Composition.Export(typeof(IFileInfoCreator))]
#endif
	public class DotnetFileInfoCreator : IFileInfoCreator
	{
#if !DOTNET
		#region CONSTRUCTORS

		public DotnetFileInfoCreator()
		{
			FileInfoFactory.RegisterCreator(this);
		}

		#endregion
#endif
		#region METHODS

		public IFileInfo Create(string fileName)
		{
			return new DotnetFileInfo(fileName);
		}

		#endregion
	}
}