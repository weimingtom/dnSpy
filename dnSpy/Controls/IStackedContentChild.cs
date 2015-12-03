﻿/*
    Copyright (C) 2014-2015 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

namespace dnSpy.Controls {
	/// <summary>
	/// Can be added to a <see cref="StackedContent{TChild}"/>
	/// </summary>
	interface IStackedContentChild {
		/// <summary>
		/// Gets the UI object
		/// </summary>
		object UIObject { get; }

		/// <summary>
		/// Gets the <see cref="IStackedContent"/> instance. Can only be written by <see cref="IStackedContent"/>
		/// </summary>
		IStackedContent StackedContent { get; set; }//TODO: Remove if this is never used
	}
}