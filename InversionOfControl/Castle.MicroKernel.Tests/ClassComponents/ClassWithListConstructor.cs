// Copyright 2004-2005 Castle Project - http://www.castleproject.org/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Castle.MicroKernel.Tests.ClassComponents
{
	using System;
	using System.Collections;

	public class ClassWithListConstructor
	{
		private readonly IList services;

		public ClassWithListConstructor(IList services)
		{
			this.services = services;
		}

		public IList Services
		{
			get { return services; }
		}
	}

	public class ClassWithArrayConstructor
	{
		private readonly ICommon[] services;

		public ClassWithArrayConstructor(ICommon[] services)
		{
			this.services = services;
		}

		public ICommon[] Services
		{
			get { return services; }
		}
	}
}
