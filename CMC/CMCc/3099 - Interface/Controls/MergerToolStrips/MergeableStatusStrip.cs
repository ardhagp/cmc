// Copyright 2012 Herman Schoenfeld, Sphere 10 Software
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

using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace VisualInheritanceFixer {

	/// <summary>
	/// This component allows you to modify a base forms ToolStrip. 
	/// Microsoft has intentionally added this limitation due to the complexities it could not overcome. This component simply works around
	/// those limitations by allowing you to merge a (hidden) tool strip on the sub form with the readonly inherited base form.
	/// </summary>
	public class MergeableStatusStrip : StatusStrip {
		private ToolStripVisualInheritanceFixer _fixer;

		public MergeableStatusStrip() {
			_fixer = new ToolStripVisualInheritanceFixer();
			_fixer.ToolStrip = this;
		}

		protected override void InitLayout() {
			base.InitLayout();
			Visible = false;
		}


		/// <summary>
		/// The base form's menu strip.
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[Description("Set this to the base forms StatusStrip. If you can't find it, make sure it's modifer is set to to 'protected' or greater.")]
		[Category("Behavior")]
		public StatusStrip InheritedToolStrip { 
			get {
				return _fixer.InheritedToolStrip as StatusStrip;
			}
			set {
				_fixer.InheritedToolStrip = (value as StatusStrip);
			}
		}

	}
}
