#pragma checksum "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Timer\blazorserver01\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48151d9a752bdfae4c5c9850be38e46e777f8657"
// <auto-generated/>
#pragma warning disable 1591
namespace blazorserver01.Pages
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Timer\blazorserver01\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Timer\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Timer\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Timer\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Timer\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Timer\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Timer\blazorserver01\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Timer\blazorserver01\_Imports.razor"
using blazorserver01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Timer\blazorserver01\_Imports.razor"
using blazorserver01.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Timer\blazorserver01\Pages\Counter.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Timer\blazorserver01\Pages\Counter.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Timer\blazorserver01\Pages\Counter.razor"
using Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 7 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Timer\blazorserver01\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "svg");
            __builder.AddAttribute(6, "width", "200");
            __builder.AddAttribute(7, "height", "200");
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 9 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Timer\blazorserver01\Pages\Counter.razor"
     foreach (var ball in balls){

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "    ");
            __builder.OpenElement(10, "circle");
            __builder.AddAttribute(11, "cx", 
#nullable restore
#line 10 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Timer\blazorserver01\Pages\Counter.razor"
                 ball.x

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "cy", 
#nullable restore
#line 10 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Timer\blazorserver01\Pages\Counter.razor"
                              ball.y

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "r", "5");
            __builder.AddAttribute(14, "fill", 
#nullable restore
#line 10 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Timer\blazorserver01\Pages\Counter.razor"
                                                   ball.color

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 11 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Timer\blazorserver01\Pages\Counter.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "<br>\r\n");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "class", "btn btn-primary");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Timer\blazorserver01\Pages\Counter.razor"
                                          StartAnimation

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, "Start");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "class", "btn btn-primary");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Timer\blazorserver01\Pages\Counter.razor"
                                          StopAnimation

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "Stop");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Timer\blazorserver01\Pages\Counter.razor"
       
    private static int currentCount = 0;
    List<MovingBall> balls = new List<MovingBall>();
    static Timer mytimer = new Timer();
    private void init_balls(){
        Random random = new Random(230);
        MovingBall p;
        for(int i=0; i<50; i++){
            int x=random.Next(10,190);
            int y=random.Next(10,190);
            p = new MovingBall(x,y);
            p.color = "#ABE280";
            p.setLimitX(10,190);
            p.setLimitY(10,190);
            x=random.Next(0,4);
            y=random.Next(0,4);
            p.setVelocity(x,y);
            balls.Add(p);
        }
    }
   private void StartAnimation()
    {
            init_balls();
            mytimer.Interval = 50;
            mytimer.Elapsed += Animation;  
            mytimer.Start();
            currentCount++;
    }
    private void StopAnimation(){
        mytimer.Stop();
    }

    private void Animation(object sender,EventArgs e)
    {
        currentCount++;
        foreach (var ball in balls) ball.next();
        InvokeAsync(StateHasChanged);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
