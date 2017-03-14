<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CategoryList.ascx.cs" Inherits="GameShop.Controls.CategoryList" %>
<%= CreateHomeLink()  %>
<% foreach (string item in GetCategories())
       
    {
        Response.Write(String.Format(CreateLinkHtml(item)));
    } 
   
%>