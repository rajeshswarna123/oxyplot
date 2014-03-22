﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LineAnnotation.cs" company="OxyPlot">
//   The MIT License (MIT)
//   
//   Copyright (c) 2012 Oystein Bjorke
//   
//   Permission is hereby granted, free of charge, to any person obtaining a
//   copy of this software and associated documentation files (the
//   "Software"), to deal in the Software without restriction, including
//   without limitation the rights to use, copy, modify, merge, publish,
//   distribute, sublicense, and/or sell copies of the Software, and to
//   permit persons to whom the Software is furnished to do so, subject to
//   the following conditions:
//   
//   The above copyright notice and this permission notice shall be included
//   in all copies or substantial portions of the Software.
//   
//   THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS
//   OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
//   MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
//   IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
//   CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
//   TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
//   SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// </copyright>
// <summary>
//   This is a WPF wrapper of OxyPlot.LineAnnotation
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace OxyPlot.Wpf
{
    using System.Windows;

    using OxyPlot.Annotations;

    /// <summary>
    /// This is a WPF wrapper of OxyPlot.LineAnnotation
    /// </summary>
    public class LineAnnotation : PathAnnotation
    {
        /// <summary>
        /// The line type property.
        /// </summary>
        public static readonly DependencyProperty LineTypeProperty = DependencyProperty.Register(
            "Type",
            typeof(LineAnnotationType),
            typeof(LineAnnotation),
            new PropertyMetadata(LineAnnotationType.LinearEquation, DataChanged));

        /// <summary>
        /// The intercept property.
        /// </summary>
        public static readonly DependencyProperty InterceptProperty = DependencyProperty.Register(
            "Intercept", typeof(double), typeof(LineAnnotation), new PropertyMetadata(0.0, DataChanged));

        /// <summary>
        /// The maximum x property.
        /// </summary>
        public static readonly DependencyProperty MaximumXProperty = DependencyProperty.Register(
            "MaximumX", typeof(double), typeof(LineAnnotation), new PropertyMetadata(double.MaxValue, DataChanged));

        /// <summary>
        /// The maximum y property.
        /// </summary>
        public static readonly DependencyProperty MaximumYProperty = DependencyProperty.Register(
            "MaximumY", typeof(double), typeof(LineAnnotation), new PropertyMetadata(double.MaxValue, DataChanged));

        /// <summary>
        /// The minimum x property.
        /// </summary>
        public static readonly DependencyProperty MinimumXProperty = DependencyProperty.Register(
            "MinimumX", typeof(double), typeof(LineAnnotation), new PropertyMetadata(double.MinValue, DataChanged));

        /// <summary>
        /// The minimum y property.
        /// </summary>
        public static readonly DependencyProperty MinimumYProperty = DependencyProperty.Register(
            "MinimumY", typeof(double), typeof(LineAnnotation), new PropertyMetadata(double.MinValue, DataChanged));

        /// <summary>
        /// The slope property.
        /// </summary>
        public static readonly DependencyProperty SlopeProperty = DependencyProperty.Register(
            "Slope", typeof(double), typeof(LineAnnotation), new PropertyMetadata(0.0, DataChanged));

        /// <summary>
        /// The x property.
        /// </summary>
        public static readonly DependencyProperty XProperty = DependencyProperty.Register(
            "X", typeof(double), typeof(LineAnnotation), new PropertyMetadata(0.0, DataChanged));

        /// <summary>
        /// The y property.
        /// </summary>
        public static readonly DependencyProperty YProperty = DependencyProperty.Register(
            "Y", typeof(double), typeof(LineAnnotation), new PropertyMetadata(0.0, DataChanged));

        /// <summary>
        /// Initializes a new instance of the <see cref = "LineAnnotation" /> class.
        /// </summary>
        public LineAnnotation()
        {
            this.InternalAnnotation = new Annotations.LineAnnotation();
        }

        /// <summary>
        /// Gets or sets Intercept.
        /// </summary>
        public double Intercept
        {
            get
            {
                return (double)this.GetValue(InterceptProperty);
            }

            set
            {
                this.SetValue(InterceptProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets MaximumX.
        /// </summary>
        public double MaximumX
        {
            get
            {
                return (double)this.GetValue(MaximumXProperty);
            }

            set
            {
                this.SetValue(MaximumXProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets MaximumY.
        /// </summary>
        public double MaximumY
        {
            get
            {
                return (double)this.GetValue(MaximumYProperty);
            }

            set
            {
                this.SetValue(MaximumYProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets MinimumX.
        /// </summary>
        public double MinimumX
        {
            get
            {
                return (double)this.GetValue(MinimumXProperty);
            }

            set
            {
                this.SetValue(MinimumXProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets MinimumY.
        /// </summary>
        public double MinimumY
        {
            get
            {
                return (double)this.GetValue(MinimumYProperty);
            }

            set
            {
                this.SetValue(MinimumYProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets Slope.
        /// </summary>
        public double Slope
        {
            get
            {
                return (double)this.GetValue(SlopeProperty);
            }

            set
            {
                this.SetValue(SlopeProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        public LineAnnotationType Type
        {
            get
            {
                return (LineAnnotationType)this.GetValue(LineTypeProperty);
            }

            set
            {
                this.SetValue(LineTypeProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets X.
        /// </summary>
        public double X
        {
            get
            {
                return (double)this.GetValue(XProperty);
            }

            set
            {
                this.SetValue(XProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets Y.
        /// </summary>
        public double Y
        {
            get
            {
                return (double)this.GetValue(YProperty);
            }

            set
            {
                this.SetValue(YProperty, value);
            }
        }

        /// <summary>
        /// Creates the internal annotation object.
        /// </summary>
        /// <returns>
        /// The annotation.
        /// </returns>
        public override Annotations.Annotation CreateModel()
        {
            this.SynchronizeProperties();
            return this.InternalAnnotation;
        }

        /// <summary>
        /// Synchronizes the properties.
        /// </summary>
        public override void SynchronizeProperties()
        {
            base.SynchronizeProperties();
            var a = (Annotations.LineAnnotation)this.InternalAnnotation;
            a.Type = this.Type;
            a.Slope = this.Slope;
            a.Intercept = this.Intercept;
            a.X = this.X;
            a.Y = this.Y;

            a.MinimumX = this.MinimumX;
            a.MaximumX = this.MaximumX;
            a.MinimumY = this.MinimumY;
            a.MaximumY = this.MaximumY;
        }
    }
}