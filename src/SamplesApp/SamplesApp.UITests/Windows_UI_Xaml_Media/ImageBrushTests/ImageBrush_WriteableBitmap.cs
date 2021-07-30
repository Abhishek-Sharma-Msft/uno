﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SamplesApp.UITests.TestFramework;
using Uno.UITest.Helpers.Queries;

namespace SamplesApp.UITests.Windows_UI_Xaml_Media.ImageBrushTests
{
	[TestFixture]
	[ActivePlatforms(Platform.Android, Platform.Browser)] // https://github.com/unoplatform/uno/issues/195
	public partial class ImageBrush_WriteableBitmap : SampleControlUITestBase
	{
		[Test]
		[AutoRetry]
		public void When_UseWriteablBitmapAsImageBrushSource()
		{
			Run("UITests.Windows_UI_Xaml_Media.ImageBrushTests.ImageBrush_WriteableBitmap");

			var sut = _app.WaitForElement("SUT").Single().Rect;
			using var result = TakeScreenshot("Result", ignoreInSnapshotCompare: false);

			ImageAssert.HasColorAt(result, sut.CenterX, sut.CenterY, Color.BlueViolet);
		}
	}
}
