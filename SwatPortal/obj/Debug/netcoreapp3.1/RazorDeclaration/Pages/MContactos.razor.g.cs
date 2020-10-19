#pragma checksum "D:\Archivos\Escritorio\Swat\V2\SwatPortal\SwatPortal\Pages\MContactos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac1f34ca21fd8ba23f0a5154525f8fcd4a6578cd"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SwatPortal.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Archivos\Escritorio\Swat\V2\SwatPortal\SwatPortal\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Archivos\Escritorio\Swat\V2\SwatPortal\SwatPortal\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Archivos\Escritorio\Swat\V2\SwatPortal\SwatPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Archivos\Escritorio\Swat\V2\SwatPortal\SwatPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Archivos\Escritorio\Swat\V2\SwatPortal\SwatPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Archivos\Escritorio\Swat\V2\SwatPortal\SwatPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Archivos\Escritorio\Swat\V2\SwatPortal\SwatPortal\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Archivos\Escritorio\Swat\V2\SwatPortal\SwatPortal\_Imports.razor"
using SwatPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Archivos\Escritorio\Swat\V2\SwatPortal\SwatPortal\_Imports.razor"
using SwatPortal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Archivos\Escritorio\Swat\V2\SwatPortal\SwatPortal\_Imports.razor"
using SwatPortal.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Archivos\Escritorio\Swat\V2\SwatPortal\SwatPortal\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Archivos\Escritorio\Swat\V2\SwatPortal\SwatPortal\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Archivos\Escritorio\Swat\V2\SwatPortal\SwatPortal\Pages\MContactos.razor"
using SwatPortal.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Archivos\Escritorio\Swat\V2\SwatPortal\SwatPortal\Pages\MContactos.razor"
using SwatPortal.Entidades;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Archivos\Escritorio\Swat\V2\SwatPortal\SwatPortal\Pages\MContactos.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/contactos")]
    public partial class MContactos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 107 "D:\Archivos\Escritorio\Swat\V2\SwatPortal\SwatPortal\Pages\MContactos.razor"
       
        

    RadzenGrid<Contacto> contactoGrid;
    public List<Contacto> contactos;

    protected override async Task OnInitializedAsync()
    {
        contactos = await contactoService.GetAllContactos();
    }

    void EditRow(Contacto contacto)
    {
        contactoGrid.EditRow(contacto);
    }

    async Task SaveRow(Contacto contacto)
    {
        await contactoService.SaveContacto(contacto);
        contactoGrid.UpdateRow(contacto);
    }

    void CancelEdit(Contacto contacto)
    {
        contactoGrid.CancelEditRow(contacto);
    }

    async Task DeleteRow(Contacto contacto)
    {
        contactos.Remove(contacto);
        contactoGrid.Reload();
        await contactoService.DeleteContacto(contacto.IdContacto);
    }

    void InsertRow()
    {
        contactoGrid.InsertRow(new Contacto());
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationDbContext dbContext { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ContactoService contactoService { get; set; }
    }
}
#pragma warning restore 1591