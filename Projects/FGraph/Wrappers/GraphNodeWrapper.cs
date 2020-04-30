﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Newtonsoft.Json.Linq;

namespace FGraph
{
    [DebuggerDisplay("{NodeName}")]
    public class GraphNodeWrapper : GraphWrapper
    {
        public class Link
        {
            public GraphLinkWrapper Traversal { get; set; }
            public GraphNodeWrapper Node { get; set; }
        }
        public String NodeName { get; set; }
        public String DisplayName { get; set; }
        public String CssClass { get; set; }

        public List<Link> ParentLinks { get; } = new List<Link>();
        public List<Link> ChildLinks { get; } = new List<Link>();

        public GraphNodeWrapper(JToken data) : base(data)
        {
            this.NodeName = this.RequiredValue("GraphNode.nodeName", data["nodeName"]);
            this.DisplayName = this.RequiredValue("GraphNode.displayName", data["displayName"]);
            this.CssClass = this.OptionalValue("GraphNode.cssClass", data["cssClass"]);
        }

        public void AddChild(GraphLinkWrapper gLink, GraphNodeWrapper child)
        {
            Link link = new Link
            {
                Node = child,
                Traversal = gLink
            };
            this.ChildLinks.Add(link);
        }

        public void AddParent(GraphLinkWrapper gLink, GraphNodeWrapper parent)
        {
            Link link = new Link
            {
                Node = parent,
                Traversal = gLink
            };
            this.ParentLinks.Add(link);
        }
    }
}