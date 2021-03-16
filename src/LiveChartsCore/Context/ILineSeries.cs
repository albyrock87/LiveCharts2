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
    /// Defines a line series plot.
    /// </summary>
    /// <typeparam name="TDrawingContext">The type of the drawing context.</typeparam>
    /// <seealso cref="IDrawableSeries{TDrawingContext}" />
    public interface ILineSeries<TDrawingContext> : IDrawableSeries<TDrawingContext>
        where TDrawingContext : DrawingContext
    {
        /// <summary>
        /// Gets or sets the size of the geometry.
        /// </summary>
        /// <value>
        /// The size of the geometry.
        /// </value>
        double GeometrySize { get; set; }

        /// <summary>
        /// Gets or sets the line smoothness, where 0 is a staright line, and 1 the most curved line, default is 0.65
        /// </summary>
        /// <value>
        /// The line smoothness.
        /// </value>
        double LineSmoothness { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the line should split every null point, 
        /// enabling it has a performance impact, defaulty is true.
        /// </summary>
        bool EnableNullSplitting { get; set; }

        /// <summary>
        /// Gets or sets the geometry fill.
        /// </summary>
        /// <value>
        /// The shapes fill.
        /// </value>
        IDrawableTask<TDrawingContext>? GeometryFill { get; set; }

        /// <summary>
        /// Gets or sets the geometry stroke.
        /// </summary>
        /// <value>
        /// The shapes stroke.
        /// </value>
        IDrawableTask<TDrawingContext>? GeometryStroke { get; set; }

        /// Gets or sets a delegate that will be called everytime a <see cref="ChartPoint{TModel, TVisual, TLabel, TDrawingContext}"/>
        /// instance is created by this series.
        /// </summary>
        Action<ILineBezierVisualChartPoint<TDrawingContext>, IChartView<TDrawingContext>>? OnPointCreated { get; set; }

        /// <summary>
        /// Gets or sets a delegate that will be called everytime a <see cref="ChartPoint{TModel, TVisual, TLabel, TDrawingContext}"/> instance
        /// is added to a state.
        /// </summary>
        Action<ILineBezierVisualChartPoint<TDrawingContext>, IChartView<TDrawingContext>>? OnPointAddedToState { get; set; }

        /// <summary>
        /// Gets or sets a delegate that will be called everytime a <see cref="ChartPoint{TModel, TVisual, TLabel, TDrawingContext}"/> instance
        /// is removed from a state.
        /// </summary>
        Action<ILineBezierVisualChartPoint<TDrawingContext>, IChartView<TDrawingContext>>? OnPointRemovedFromState { get; set; }
    }
}