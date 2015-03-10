// Licensed to the Apache Software Foundation (ASF) under one
// or more contributor license agreements.  See the NOTICE file
// distributed with this work for additional information
// regarding copyright ownership.  The ASF licenses this file
// to you under the Apache License, Version 2.0 (the
// "License"); you may not use this file except in compliance
// with the License.  You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.
using System;
using System.Linq;
using Microsoft.Deployment.WindowsInstaller;
using Microsoft.Deployment.WindowsInstaller.Linq;
// MakeSfxCA.exe
/// <summary>
/// Sample CustomActions using Linq
/// </summary>
public class CustomActions
{

	/// <summary>
	/// CustomAction1 Logging all the available properties
	/// </summary>
   [CustomAction]
   public static ActionResult CustomAction1(Session session)
   {
		session.Log("Begin CustomAction1");
	    // MAGIC!!  http://windows-installer-xml-wix-toolset.687559.n2.nabble.com/Re-DTF-in-WiX-td711458.html
		using(var database = session.Database.AsQueryable() )
		{
			var properties = from p in database.Properties
							 select p;

			foreach (var property in properties)
			{
				session.Log(String.Format("{0} = {1}", property.Property, property.Value));
			}
		}
	   
       return ActionResult.Success;
   }
}