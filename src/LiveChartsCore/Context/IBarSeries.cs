﻿// The MIT License(MIT)

// Copyright(c) 2021 Alberto Rodriguez Orozco & LiveCharts Contributors

// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:

// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.

// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using LiveChartsCore.Drawing;
using System;

namespace LiveChartsCore.Context
{
    /// <summary>
    /// Defines a bar series point.
    /// </summary>
    /// <typeparam name="TDrawingContext">The type of the drawing context.</typeparam>
    /// <seealso cref="LiveChartsCore.Context.IDrawableSeries{TDrawingContext}" />
    public interface IBarSeries<TDrawingContext> : IDrawableSeries<TDrawingContext>
        where TDrawingContext : DrawingContext
    {
        /// <summary>
        /// Gets or sets the maximum width of the bar.
        /// </summary>
        /// <value>
        /// The maximum width of the bar.
        /// </value>
        double MaxBarWidth { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the bar position respects the other bars that share 
        /// the same <see cref="IChartPoint.SecondaryValue"/>.
        /// </summary>
        bool IgnoresBarPosition { get; set; }

        /// <summary>
        /// Gets or sets the geometry stroke.
        /// </summary>
        /// <value>
        /// The shapes stroke.
        /// </value>
        Action<ISizedGeometry<TDrawingContext>, IChartView<TDrawingContext>>? OnPointCreated { get; set; }

        /// <summary>
        /// Gets or sets a delegate that will be called everytime a <see cref="ChartPoint{TModel, TVisual, TLabel, TDrawingContext}"/> instance
        /// is added to a state.
        /// </summary>
        Action<ISizedGeometry<TDrawingContext>, IChartView<TDrawingContext>>? OnPointAddedToState { get; set; }

        /// <summary>
        /// Gets or sets a delegate that will be called everytime a <see cref="ChartPoint{TModel, TVisual, TLabel, TDrawingContext}"/> instance
        /// is removed from a state.
        /// </summary>
        Action<ISizedGeometry<TDrawingContext>, IChartView<TDrawingContext>>? OnPointRemovedFromState { get; set; }
    }
}