namespace Kendo.Mvc.UI.Fluent
{
    using System;

    /// <summary>
    /// Defines the fluent interface for configuring the <see cref="ChartSelectionMousewheelBuilder"/>.
    /// </summary>
    public class ChartSelectionMousewheelBuilder : IHideObjectMembers
    {
        private readonly ChartSelectionMousewheel mousewheel;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartSelectionMousewheelBuilder" /> class.
        /// </summary>
        /// <param name="selectionMousewheel">The mousewheel zoom settings.</param>
        public ChartSelectionMousewheelBuilder(ChartSelectionMousewheel selectionMousewheel)
        {
            mousewheel = selectionMousewheel;
        }

        /// <summary>
        /// Reverses the mousewheel direction.
        /// Rotating the wheel down will shrink the selection, rotating up will expand it.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        /// &lt;% Html.Kendo().Chart()
        ///           .Name("Chart")
        ///           .CategoryAxis(axis => axis.Select(select => select
        ///               .From(fromDate).To(toDate)
        ///               .Mousewheel(mw => mw.Reverse())
        ///           ))
        ///           .Render();
        /// %&gt;
        /// </code>
        /// </example>
        public ChartSelectionMousewheelBuilder Reverse()
        {
            mousewheel.Reverse = true;
            return this;
        }

        /// <summary>
        /// Sets a value indicating if the mousewheel should be reversed.
        /// </summary>
        /// <param name="reverse">
        /// true: scrolling up shrinks the selection.
        /// false: scrolling down expands the selection.
        /// </param>
        /// <example>
        /// <code lang="CS">
        /// &lt;% Html.Kendo().Chart()
        ///           .Name("Chart")
        ///           .CategoryAxis(axis => axis.Select(select => select
        ///               .From(fromDate).To(toDate)
        ///               .Mousewheel(mw => mw.Reverse(true))
        ///           ))
        ///           .Render();
        /// %&gt;
        /// </code>
        /// </example>
        public ChartSelectionMousewheelBuilder Reverse(bool reverse)
        {
            mousewheel.Reverse = reverse;
            return this;
        }

        /// <summary>
        /// Sets the mousewheel zoom type
        /// </summary>
        /// <param name="fromDate">The mousewheel zoom type. Default value is ChartZoomDirection.Both</param>
        /// <example>
        /// <code lang="CS">
        /// &lt;% Html.Kendo().Chart()
        ///           .Name("Chart")
        ///           .CategoryAxis(axis => axis.Select(select =>
        ///               select.From(from).To(to)
        ///               .Mousewheel(mw => mw.Zoom(ChartZoomDirection.Left))
        ///           ))
        ///           .Render();
        /// %&gt;
        /// </code>
        /// </example>
        public ChartSelectionMousewheelBuilder Zoom(ChartZoomDirection zoom)
        {
            mousewheel.Zoom = zoom;
            return this;
        }
    }
}
