﻿//
// SwitchableGroupOption.cs
//
// Author:
//       marcbookpro19 <v-marcguo@microsoft.com>
//
// Copyright (c) 2021 
//

using System;
using Microsoft.VisualStudioUI.Options.Models;

namespace Microsoft.VisualStudioUI.Options
{
	public class SwitchableGroupOption : Option
	{
		public ViewModelProperty<bool> IsOn { get; }

		public event EventHandler? SwitchChanged;


		public void SwitchChangedInvoke(object sender, EventArgs e)
		{
			SwitchChanged?.Invoke(sender, e);
		}

		public SwitchableGroupOption(ViewModelProperty<bool> isOn)
		{
			IsOn = isOn;
			Platform = OptionFactoryPlatform.Instance.CreateSwitchableGroupOptionPlatform(this);
		}
	}
}
