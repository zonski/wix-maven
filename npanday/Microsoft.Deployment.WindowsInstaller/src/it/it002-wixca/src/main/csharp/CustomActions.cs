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
//using System.IO;
using Microsoft.Deployment.WindowsInstaller;
// MakeSfxCA.exe
public class CustomActions
{
   [CustomAction]
   public static ActionResult CustomAction1(Session session)
   {
       session.Log("Begin CustomAction1");

	   session.Log("CustomAction1: " + session.CustomActionData["INSTALLDIR"] );
	   
       return ActionResult.Success;
   }
   
   [CustomAction]
   public static ActionResult CustomAction2(Session session)
   {
       session.Log("Begin CustomAction2");

	   session.Log("CustomAction2: " + session.CustomActionData["INSTALLDIR"] );
	   session.CustomActionData["SUBINSTALLDIR"] = session.CustomActionData["INSTALLDIR"] + "\\subdir";
	   session.Log("CustomAction2: " + session.CustomActionData["SUBINSTALLDIR"] );
	   
       return ActionResult.Success;
   }
}