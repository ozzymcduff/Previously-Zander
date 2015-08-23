using NUnit.Framework;
using System;
using SomeFSharpLibrary;
using Zander;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
	[TestFixture]
	public class Can_digest_customer_that_contain_optional_values
	{
		private enum Option 
		{
			None=0,
			Some=1
		}
		[Test]
		public void Can_handle_none ()
		{
			var customerWithNone = Customers.oskarOhlsson;
			var noneTriggered = new List<bool> ();
			customerWithNone.SSN.Match (
				some: _ => Assert.Fail (),
				none: () => noneTriggered.Add(true));
			Assert.That (noneTriggered.Any());
			var result = customerWithNone.SSN.Match (
				some: _ =>  Option.Some,
				none: () => Option.None);
			Assert.AreEqual (Option.None, result);
		}
		[Test]
		public void Can_handle_some ()
		{
			var customerWithSome = Customers.fredrikKarlsson;
			var noneTriggered = new List<bool> ();
			customerWithSome.SSN.Match (
				some: _ => noneTriggered.Add(true),
				none: () =>  Assert.Fail ());
			Assert.That (noneTriggered.Any());
			var result = customerWithSome.SSN.Match (
				some: _ =>  Option.Some,
				none: () => Option.None);
			Assert.AreEqual (Option.Some, result);
		}
	}
}

