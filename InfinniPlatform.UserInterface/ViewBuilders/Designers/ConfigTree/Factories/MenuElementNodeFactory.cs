﻿using System.Collections.Generic;

using InfinniPlatform.Core.Metadata;
using InfinniPlatform.UserInterface.ViewBuilders.Designers.ConfigTree.Commands;

namespace InfinniPlatform.UserInterface.ViewBuilders.Designers.ConfigTree.Factories
{
    internal sealed class MenuElementNodeFactory : IConfigElementNodeFactory
    {
        public const string ElementType = MetadataType.Menu;

        public void Create(ConfigElementNodeBuilder builder, ICollection<ConfigElementNode> elements,
            ConfigElementNode elementNode)
        {
            elementNode.ElementId = FactoryHelper.BuildId(elementNode);
            elementNode.ElementName = FactoryHelper.BuildName(elementNode);

            elementNode.RefreshCommand = FactoryHelper.NoRefreshCommand;
            elementNode.RegisterEditCommand(builder);
            elementNode.DeleteCommand = new DeleteElementCommand(builder, elements, elementNode);
            elementNode.RegisterCopyCommand();
            elementNode.PasteCommand = FactoryHelper.NoPasteCommand;
        }
    }
}