﻿// The MIT License(MIT)
//
// Copyright(c) 2021 Alberto Rodriguez Orozco & LiveCharts Contributors
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using LiveChartsCore.SkiaSharpView.Drawing;
using SkiaSharp;

namespace LiveChartsCore.SkiaSharpView.Painting.ImageFilters;

/// <summary>
/// Creates a drop shadow image filter.
/// </summary>
/// <seealso cref="ImageFilter" />
/// <remarks>
/// Initializes a new instance of the <see cref="DropShadow"/> class.
/// </remarks>
/// <param name="dx">The dx.</param>
/// <param name="dy">The dy.</param>
/// <param name="sigmaX">The sigma x.</param>
/// <param name="sigmaY">The sigma y.</param>
/// <param name="color">The color.</param>
/// <param name="input">The input.</param>
public class DropShadow(
    float dx,
    float dy,
    float sigmaX,
    float sigmaY,
    SKColor color,
    SKImageFilter? input = null)
        : ImageFilter
{

    /// <summary>
    /// Clones this instance.
    /// </summary>
    /// <returns></returns>
    /// <exception cref="System.NotImplementedException"></exception>
    public override ImageFilter Clone()
    {
        return new DropShadow(dx, dy, sigmaX, sigmaY, color, input);
    }

    /// <summary>
    /// Creates the image filter.
    /// </summary>
    /// <param name="drawingContext">The drawing context.</param>
    public override void CreateFilter(SkiaSharpDrawingContext drawingContext)
    {
        SKImageFilter = SKImageFilter.CreateDropShadow(dx, dy, sigmaX, sigmaY, color, input);
    }
}
