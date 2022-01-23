using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherApp
{
    public class TaskModel
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
    }
    public class CreateTaskModel
    {
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public string Description { get; set; }
    }
    public class UpdateTaskModel
    {
        public string Description { get; set; }
        public bool IsDone { get; set; }
    }
}