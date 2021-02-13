﻿//
// Copyright 2020 David Roller 
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//  http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
using System;
using System.Diagnostics;
using System.IO;

namespace OpenFolderExtension.CommandsCommandLine
{
    internal static class CommandLine
    {
        public static void Show(FileInfo path)
        {
            if (path == null)
            {
                throw new NullReferenceException("Empty path cannot be displayed in command line");
            }

            Process.Start("cmd.exe", " /K \"cd /D " + path.GetFirstExistingDirectory().FullName + "\"");
        }
    }
}
