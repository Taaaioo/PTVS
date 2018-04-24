// Python Tools for Visual Studio
// Copyright(c) Microsoft Corporation
// All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the License); you may not use
// this file except in compliance with the License. You may obtain a copy of the
// License at http://www.apache.org/licenses/LICENSE-2.0
//
// THIS CODE IS PROVIDED ON AN  *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS
// OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY
// IMPLIED WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE,
// MERCHANTABLITY OR NON-INFRINGEMENT.
//
// See the Apache Version 2.0 License for specific language governing
// permissions and limitations under the License.

using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestRunnerInterop;

namespace PythonToolsUITestsRunner {
    [TestClass]
    public class ErrorListTaskListTests {
        #region UI test boilerplate
        public VsTestInvoker _vs => new VsTestInvoker(
            VsTestContext.Instance,
            // Remote container (DLL) name
            "Microsoft.PythonTools.Tests.PythonToolsUITests",
            // Remote class name
            $"PythonToolsUITests.{GetType().Name}"
        );

        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void TestInitialize() => VsTestContext.Instance.TestInitialize(TestContext.DeploymentDirectory);
        [TestCleanup]
        public void TestCleanup() => VsTestContext.Instance.TestCleanup();
        [ClassCleanup]
        public static void ClassCleanup() => VsTestContext.Instance.Dispose();
        #endregion

        [TestMethod, Priority(2)]
        [TestCategory("Installed")]
        public void ErrorList() {
            _vs.RunTest(nameof(PythonToolsUITests.ErrorListTaskListTests.ErrorList));
        }

        [TestMethod, Priority(0)]
        [TestCategory("Installed")]
        public void CommentTaskList() {
            _vs.RunTest(nameof(PythonToolsUITests.ErrorListTaskListTests.CommentTaskList));
        }

        [TestMethod, Priority(0)]
        [TestCategory("Installed")]
        public void ErrorListAndTaskListAreClearedWhenProjectIsDeleted() {
            _vs.RunTest(nameof(PythonToolsUITests.ErrorListTaskListTests.ErrorListAndTaskListAreClearedWhenProjectIsDeleted));
        }

        [TestMethod, Priority(0)]
        [TestCategory("Installed")]
        public void ErrorListAndTaskListAreClearedWhenProjectIsUnloaded() {
            _vs.RunTest(nameof(PythonToolsUITests.ErrorListTaskListTests.ErrorListAndTaskListAreClearedWhenProjectIsUnloaded));
        }

        [TestMethod, Priority(0)]
        [TestCategory("Installed")]
        public void ErrorListAndTaskListAreClearedWhenProjectWithMultipleFilesIsUnloaded() {
            _vs.RunTest(nameof(PythonToolsUITests.ErrorListTaskListTests.ErrorListAndTaskListAreClearedWhenProjectWithMultipleFilesIsUnloaded));
        }

        [TestMethod, Priority(2)]
        [TestCategory("Installed")]
        public void ErrorListAndTaskListAreClearedWhenFileIsDeleted() {
            _vs.RunTest(nameof(PythonToolsUITests.ErrorListTaskListTests.ErrorListAndTaskListAreClearedWhenFileIsDeleted));
        }

        [TestMethod, Priority(0)]
        [TestCategory("Installed")]
        public void ErrorListEmptyForValidTypingFile() {
            _vs.RunTest(nameof(PythonToolsUITests.ErrorListTaskListTests.ErrorListEmptyForValidTypingFile));
        }
    }
}
