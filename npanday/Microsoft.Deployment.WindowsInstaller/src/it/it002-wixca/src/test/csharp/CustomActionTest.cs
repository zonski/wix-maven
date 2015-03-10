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
using NUnit.Framework;
using Microsoft.Deployment.WindowsInstaller;
//using CustomActions;

namespace npanday.wix
{

	[TestFixture]
	public class CustomActionTest
	{
		Database database;
		Session session;
		
		[SetUp]
		protected void SetUp()
		{
			// database = new Database( Path+"Test.msi", DatabaseOpenMode.Create );
			// database.Commit();
			// database.Dispose();
			// session = new Session( Path+"Test.msi" );
			// session = Database.
		}

		[Test]
		public void TestCustomAction1()
		{
//			CustomActions.CustomAction1(session);
		}
		
		[Test]
		public void TestCustomAction2()
		{
//			CustomActions.CustomAction2(session);
		}
	}
}

