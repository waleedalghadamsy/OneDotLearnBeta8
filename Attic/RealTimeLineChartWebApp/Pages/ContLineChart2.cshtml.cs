using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SkiaSharp;
using System.Threading.Tasks;

namespace RealTimeLineChartWebApp.Pages
{
    public class ContLineChart2Model : PageModel
    {
        private static readonly Random _rand = new Random();

        public async Task<IActionResult> OnGetChart()
        {
            int width = 600;
            int height = 300;
            int points = 50;
            float maxY = 100;

            using var surface = SKSurface.Create(new SKImageInfo(width, height));
            var canvas = surface.Canvas;

            // White background
            canvas.Clear(SKColors.White);

            // Draw axes
            var axisPaint = new SKPaint { Color = SKColors.Black, StrokeWidth = 2 };
            canvas.DrawLine(40, 10, 40, height - 30, axisPaint);  // Y-axis
            canvas.DrawLine(40, height - 30, width - 10, height - 30, axisPaint); // X-axis

            // Prepare line paint
            var linePaint = new SKPaint
            {
                Color = SKColors.Blue,
                StrokeWidth = 2,
                IsAntialias = true
            };

            float xStep = (width - 60) / (float)(points - 1);
            float prevValue = (float)(_rand.NextDouble() * maxY);

            for (int i = 1; i < points; i++)
            {
                // Calculate new random point
                float currValue = (float)(_rand.NextDouble() * maxY);
                float x1 = 40 + xStep * (i - 1);
                float y1 = (height - 30) - (prevValue / maxY) * (height - 40);
                float x2 = 40 + xStep * i;
                float y2 = (height - 30) - (currValue / maxY) * (height - 40);

                // Draw segment
                canvas.DrawLine(x1, y1, x2, y2, linePaint);
                prevValue = currValue;

                // Non-blocking delay before next iteration
                await Task.Delay(1500);
            }

            // Render to PNG
            using var image = surface.Snapshot();
            using var data = image.Encode(SKEncodedImageFormat.Png, 80);
            return File(data.ToArray(), "image/png");
        }
    }
}
