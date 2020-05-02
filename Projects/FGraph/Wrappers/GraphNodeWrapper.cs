﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Hl7.Fhir.Model;
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
        public String ElementId { get; set; }
        public String DisplayName { get; set; }
        public String CssClass { get; set; }

        private ElementDefinition elementDef;
        public List<Link> ParentLinks { get; } = new List<Link>();
        public List<Link> ChildLinks { get; } = new List<Link>();
        public String LhsAnnotationText { get; set; }
        public String RhsAnnotationText { get; set; }

        public GraphNodeWrapper(FGrapher fGraph, JToken data) : base(fGraph, data)
        {
            this.NodeName = this.RequiredValue(data, "nodeName");
            this.DisplayName = this.RequiredValue(data, "displayName");
            this.CssClass = this.OptionalValue(data, "cssClass");
            this.ElementId = this.RequiredValue(data, "elementId");
            this.LhsAnnotationText = this.OptionalValue(data, "lhsAnnotationText");
            this.RhsAnnotationText = this.OptionalValue(data, "rhsAnnotationText");
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

        public ElementDefinition ElementDef()
        {
            if (this.elementDef == null)
                this.elementDef = this.fGraph.FindElementDefinition(this.ElementId);
            return this.elementDef;
        }

    }
}
