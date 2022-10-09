using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.JSInterop;
using Boilerplate.Applications.TodoBlazor;
using Boilerplate.Applications.TodoBlazor.Shared;
using Boilerplate.Libraries.Data.Models;
using Boilerplate.Libraries.Services;

namespace Boilerplate.Applications.TodoBlazor.Pages
{
    public partial class FetchData
    {
        [Inject]
        public TodoService TodoService { get; set; }


        public List<Todo> Todos = new List<Todo>();

        protected override async Task OnInitializedAsync()
        {
            this.Todos = this.TodoService.List().ToList();
        }
    }
}