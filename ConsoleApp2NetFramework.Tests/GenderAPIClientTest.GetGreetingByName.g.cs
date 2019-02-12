using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2NetFramework;
using System.Threading.Tasks;
using Microsoft.Pex.Framework.Generated;
// <copyright file="GenderAPIClientTest.GetGreetingByName.g.cs">Copyright ©  2019</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace ConsoleApp2NetFramework.Tests
{
    public partial class GenderAPIClientTest
    {

[TestMethod]
[PexGeneratedBy(typeof(GenderAPIClientTest))]
public void GetGreetingByName753()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Task<string> task;
      GenderAPIClient s0 = new GenderAPIClient();
      task = this.GetGreetingByName(s0, (string)null);
      disposables.Add((IDisposable)task);
      disposables.Dispose();
      Assert.IsNotNull((object)task);
      Assert.AreEqual<TaskStatus>
          (TaskStatus.WaitingForActivation, ((Task)task).Status);
      Assert.AreEqual<bool>(false, ((Task)task).IsCanceled);
      Assert.IsNull(((Task)task).AsyncState);
      Assert.AreEqual<bool>(false, ((Task)task).IsFaulted);
      Assert.IsNotNull((object)s0);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(GenderAPIClientTest))]
[Ignore]
[PexDescription("the test state was: path bounds exceeded")]
public void GetGreetingByName230()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Task<string> task;
      GenderAPIClient s0 = new GenderAPIClient();
      task = this.GetGreetingByName(s0, "Ȁ");
      disposables.Add((IDisposable)task);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(GenderAPIClientTest))]
public void GetGreetingByName344()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Task<string> task;
      GenderAPIClient s0 = new GenderAPIClient();
      task = this.GetGreetingByName(s0, "%d");
      disposables.Add((IDisposable)task);
      disposables.Dispose();
      Assert.IsNotNull((object)task);
      Assert.AreEqual<TaskStatus>
          (TaskStatus.WaitingForActivation, ((Task)task).Status);
      Assert.AreEqual<bool>(false, ((Task)task).IsCanceled);
      Assert.IsNull(((Task)task).AsyncState);
      Assert.AreEqual<bool>(false, ((Task)task).IsFaulted);
      Assert.IsNotNull((object)s0);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(GenderAPIClientTest))]
public void GetGreetingByName706()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Task<string> task;
      GenderAPIClient s0 = new GenderAPIClient();
      task = this.GetGreetingByName(s0, "%0b");
      disposables.Add((IDisposable)task);
      disposables.Dispose();
      Assert.IsNotNull((object)task);
      Assert.AreEqual<TaskStatus>
          (TaskStatus.WaitingForActivation, ((Task)task).Status);
      Assert.AreEqual<bool>(false, ((Task)task).IsCanceled);
      Assert.IsNull(((Task)task).AsyncState);
      Assert.AreEqual<bool>(false, ((Task)task).IsFaulted);
      Assert.IsNotNull((object)s0);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(GenderAPIClientTest))]
public void GetGreetingByName535()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Task<string> task;
      GenderAPIClient s0 = new GenderAPIClient();
      task = this.GetGreetingByName(s0, "%6d");
      disposables.Add((IDisposable)task);
      disposables.Dispose();
      Assert.IsNotNull((object)task);
      Assert.AreEqual<TaskStatus>
          (TaskStatus.WaitingForActivation, ((Task)task).Status);
      Assert.AreEqual<bool>(false, ((Task)task).IsCanceled);
      Assert.IsNull(((Task)task).AsyncState);
      Assert.AreEqual<bool>(false, ((Task)task).IsFaulted);
      Assert.IsNotNull((object)s0);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(GenderAPIClientTest))]
public void GetGreetingByName594()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Task<string> task;
      GenderAPIClient s0 = new GenderAPIClient();
      task = this.GetGreetingByName(s0, "%a0");
      disposables.Add((IDisposable)task);
      disposables.Dispose();
      Assert.IsNotNull((object)task);
      Assert.AreEqual<TaskStatus>
          (TaskStatus.WaitingForActivation, ((Task)task).Status);
      Assert.AreEqual<bool>(false, ((Task)task).IsCanceled);
      Assert.IsNull(((Task)task).AsyncState);
      Assert.AreEqual<bool>(false, ((Task)task).IsFaulted);
      Assert.IsNotNull((object)s0);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(GenderAPIClientTest))]
public void GetGreetingByName374()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Task<string> task;
      GenderAPIClient s0 = new GenderAPIClient();
      task = this.GetGreetingByName(s0, "%70䀀\0#%");
      disposables.Add((IDisposable)task);
      disposables.Dispose();
      Assert.IsNotNull((object)task);
      Assert.AreEqual<TaskStatus>
          (TaskStatus.WaitingForActivation, ((Task)task).Status);
      Assert.AreEqual<bool>(false, ((Task)task).IsCanceled);
      Assert.IsNull(((Task)task).AsyncState);
      Assert.AreEqual<bool>(false, ((Task)task).IsFaulted);
      Assert.IsNotNull((object)s0);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(GenderAPIClientTest))]
public void GetGreetingByName688()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Task<string> task;
      GenderAPIClient s0 = new GenderAPIClient();
      task = this.GetGreetingByName(s0, "%4A‬\0#");
      disposables.Add((IDisposable)task);
      disposables.Dispose();
      Assert.IsNotNull((object)task);
      Assert.AreEqual<TaskStatus>
          (TaskStatus.WaitingForActivation, ((Task)task).Status);
      Assert.AreEqual<bool>(false, ((Task)task).IsCanceled);
      Assert.IsNull(((Task)task).AsyncState);
      Assert.AreEqual<bool>(false, ((Task)task).IsFaulted);
      Assert.IsNotNull((object)s0);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(GenderAPIClientTest))]
public void GetGreetingByName469()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Task<string> task;
      GenderAPIClient s0 = new GenderAPIClient();
      task = this.GetGreetingByName(s0, "%7A\0#");
      disposables.Add((IDisposable)task);
      disposables.Dispose();
      Assert.IsNotNull((object)task);
      Assert.AreEqual<TaskStatus>
          (TaskStatus.WaitingForActivation, ((Task)task).Status);
      Assert.AreEqual<bool>(false, ((Task)task).IsCanceled);
      Assert.IsNull(((Task)task).AsyncState);
      Assert.AreEqual<bool>(false, ((Task)task).IsFaulted);
      Assert.IsNotNull((object)s0);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(GenderAPIClientTest))]
public void GetGreetingByName857()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Task<string> task;
      GenderAPIClient s0 = new GenderAPIClient();
      task = this.GetGreetingByName(s0, "%7A�\0#");
      disposables.Add((IDisposable)task);
      disposables.Dispose();
      Assert.IsNotNull((object)task);
      Assert.AreEqual<TaskStatus>
          (TaskStatus.WaitingForActivation, ((Task)task).Status);
      Assert.AreEqual<bool>(false, ((Task)task).IsCanceled);
      Assert.IsNull(((Task)task).AsyncState);
      Assert.AreEqual<bool>(false, ((Task)task).IsFaulted);
      Assert.IsNotNull((object)s0);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(GenderAPIClientTest))]
public void GetGreetingByName815()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Task<string> task;
      GenderAPIClient s0 = new GenderAPIClient();
      task = this.GetGreetingByName(s0, "%20𢰀#");
      disposables.Add((IDisposable)task);
      disposables.Dispose();
      Assert.IsNotNull((object)task);
      Assert.AreEqual<TaskStatus>
          (TaskStatus.WaitingForActivation, ((Task)task).Status);
      Assert.AreEqual<bool>(false, ((Task)task).IsCanceled);
      Assert.IsNull(((Task)task).AsyncState);
      Assert.AreEqual<bool>(false, ((Task)task).IsFaulted);
      Assert.IsNotNull((object)s0);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(GenderAPIClientTest))]
public void GetGreetingByName267()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Task<string> task;
      GenderAPIClient s0 = new GenderAPIClient();
      task = this.GetGreetingByName(s0, "%41𐀀#");
      disposables.Add((IDisposable)task);
      disposables.Dispose();
      Assert.IsNotNull((object)task);
      Assert.AreEqual<TaskStatus>
          (TaskStatus.WaitingForActivation, ((Task)task).Status);
      Assert.AreEqual<bool>(false, ((Task)task).IsCanceled);
      Assert.IsNull(((Task)task).AsyncState);
      Assert.AreEqual<bool>(false, ((Task)task).IsFaulted);
      Assert.IsNotNull((object)s0);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(GenderAPIClientTest))]
public void GetGreetingByName566()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Task<string> task;
      GenderAPIClient s0 = new GenderAPIClient();
      task = this.GetGreetingByName(s0, "%d🿾#");
      disposables.Add((IDisposable)task);
      disposables.Dispose();
      Assert.IsNotNull((object)task);
      Assert.AreEqual<TaskStatus>
          (TaskStatus.WaitingForActivation, ((Task)task).Status);
      Assert.AreEqual<bool>(false, ((Task)task).IsCanceled);
      Assert.IsNull(((Task)task).AsyncState);
      Assert.AreEqual<bool>(false, ((Task)task).IsFaulted);
      Assert.IsNotNull((object)s0);
    }
}
    }
}
