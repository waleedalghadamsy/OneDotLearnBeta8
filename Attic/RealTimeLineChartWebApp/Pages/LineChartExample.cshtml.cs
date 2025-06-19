using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SkiaSharp;

namespace RealTimeLineChartWebApp.Pages
{
    public class LineChartExampleModel : PageModel
    {
        private static readonly Random _rand = new Random();
        private static readonly List<float> _data = new List<float>();

        public async Task<IActionResult> OnGetAsync()
        {
            if (_data.Count >= 50)
                _data.RemoveAt(0);
            // Add a random point
            _data.Add((float)(_rand.NextDouble() * 100));

            int width = 600;
            int height = 300;

            for (int i = _data.Count; i < 50; i++)
            {
                _data.Add((float)(_rand.NextDouble() * 100));
            }

            using var surface = SKSurface.Create(new SKImageInfo(width, height));
            var canvas = surface.Canvas;

            // White background
            canvas.Clear(SKColors.White);

            // Draw axes
            var paint = new SKPaint { Color = SKColors.Black, StrokeWidth = 2 };
            canvas.DrawLine(40, 10, 40, height - 30, paint);  // Y-axis
            canvas.DrawLine(40, height - 30, width - 10, height - 30, paint); // X-axis

            // Draw line chart
            if (_data.Count > 1)
            {
                var linePaint = new SKPaint
                {
                    Color = SKColors.Blue,
                    StrokeWidth = 2,
                    IsAntialias = true
                };

                float maxY = 100;
                float xStep = (width - 60) / (float)(50 - 1);
                float datPoint = 0.0f;

                for (int i = 1; i < 50; i++)
                {
                    datPoint = (float)(_rand.NextDouble() * 100);

                    float x1 = 40 + xStep * (i - 1);
                    float y1 = (height - 30) - (datPoint / maxY) * (height - 40);
                    float x2 = 40 + xStep * i;

                    datPoint = (float)(_rand.NextDouble() * 100);

                    float y2 = (height - 30) - (datPoint / maxY) * (height - 40);

                    canvas.DrawLine(x1, y1, x2, y2, linePaint);

                    await Task.Delay(1000); //Thread.Sleep(2000); // Simulate real-time data update
                }
            }

            // Render to PNG
            using var image = surface.Snapshot();
            using var data = image.Encode(SKEncodedImageFormat.Png, 80);
            return File(data.ToArray(), "image/png");
        }
    }
}
