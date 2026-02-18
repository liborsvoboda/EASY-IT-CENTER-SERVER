import React from 'react';
import ComponentCreator from '@docusaurus/ComponentCreator';

export default [
  {
    path: '/blog',
    component: ComponentCreator('/blog', 'e21'),
    exact: true
  },
  {
    path: '/blog/archive',
    component: ComponentCreator('/blog/archive', '245'),
    exact: true
  },
  {
    path: '/blog/first-blog-post',
    component: ComponentCreator('/blog/first-blog-post', '89a'),
    exact: true
  },
  {
    path: '/blog/long-blog-post',
    component: ComponentCreator('/blog/long-blog-post', '9ad'),
    exact: true
  },
  {
    path: '/blog/mdx-blog-post',
    component: ComponentCreator('/blog/mdx-blog-post', 'e9f'),
    exact: true
  },
  {
    path: '/blog/tags',
    component: ComponentCreator('/blog/tags', '4c4'),
    exact: true
  },
  {
    path: '/blog/tags/docusaurus',
    component: ComponentCreator('/blog/tags/docusaurus', 'fb9'),
    exact: true
  },
  {
    path: '/blog/tags/facebook',
    component: ComponentCreator('/blog/tags/facebook', 'aba'),
    exact: true
  },
  {
    path: '/blog/tags/hello',
    component: ComponentCreator('/blog/tags/hello', '41a'),
    exact: true
  },
  {
    path: '/blog/tags/hola',
    component: ComponentCreator('/blog/tags/hola', '8e5'),
    exact: true
  },
  {
    path: '/blog/welcome',
    component: ComponentCreator('/blog/welcome', 'd2b'),
    exact: true
  },
  {
    path: '/community/',
    component: ComponentCreator('/community/', '506'),
    exact: true
  },
  {
    path: '/gallery',
    component: ComponentCreator('/gallery', '85d'),
    exact: true
  },
  {
    path: '/markdown-page',
    component: ComponentCreator('/markdown-page', '3d7'),
    exact: true
  },
  {
    path: '/search',
    component: ComponentCreator('/search', '5de'),
    exact: true
  },
  {
    path: '/docs',
    component: ComponentCreator('/docs', 'ad0'),
    routes: [
      {
        path: '/docs',
        component: ComponentCreator('/docs', '15f'),
        routes: [
          {
            path: '/docs',
            component: ComponentCreator('/docs', '2b7'),
            routes: [
              {
                path: '/docs/api/',
                component: ComponentCreator('/docs/api/', 'e35'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/classes/lexical_code.CodeHighlightNode',
                component: ComponentCreator('/docs/api/classes/lexical_code.CodeHighlightNode', '20f'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/classes/lexical_code.CodeNode',
                component: ComponentCreator('/docs/api/classes/lexical_code.CodeNode', 'ede'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/classes/lexical_hashtag.HashtagNode',
                component: ComponentCreator('/docs/api/classes/lexical_hashtag.HashtagNode', '5c1'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/classes/lexical_link.AutoLinkNode',
                component: ComponentCreator('/docs/api/classes/lexical_link.AutoLinkNode', '057'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/classes/lexical_link.LinkNode',
                component: ComponentCreator('/docs/api/classes/lexical_link.LinkNode', '241'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/classes/lexical_list.ListItemNode',
                component: ComponentCreator('/docs/api/classes/lexical_list.ListItemNode', 'd8c'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/classes/lexical_list.ListNode',
                component: ComponentCreator('/docs/api/classes/lexical_list.ListNode', '6cb'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/classes/lexical_mark.MarkNode',
                component: ComponentCreator('/docs/api/classes/lexical_mark.MarkNode', '7e2'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/classes/lexical_offset.OffsetView',
                component: ComponentCreator('/docs/api/classes/lexical_offset.OffsetView', 'f8b'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/classes/lexical_overflow.OverflowNode',
                component: ComponentCreator('/docs/api/classes/lexical_overflow.OverflowNode', 'd37'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/classes/lexical_react_LexicalAutoEmbedPlugin.AutoEmbedOption',
                component: ComponentCreator('/docs/api/classes/lexical_react_LexicalAutoEmbedPlugin.AutoEmbedOption', '046'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/classes/lexical_react_LexicalContextMenuPlugin.MenuOption',
                component: ComponentCreator('/docs/api/classes/lexical_react_LexicalContextMenuPlugin.MenuOption', 'b45'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/classes/lexical_react_LexicalDecoratorBlockNode.DecoratorBlockNode',
                component: ComponentCreator('/docs/api/classes/lexical_react_LexicalDecoratorBlockNode.DecoratorBlockNode', '0a9'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/classes/lexical_react_LexicalHorizontalRuleNode.HorizontalRuleNode',
                component: ComponentCreator('/docs/api/classes/lexical_react_LexicalHorizontalRuleNode.HorizontalRuleNode', 'db0'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/classes/lexical_rich_text.HeadingNode',
                component: ComponentCreator('/docs/api/classes/lexical_rich_text.HeadingNode', '96d'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/classes/lexical_rich_text.QuoteNode',
                component: ComponentCreator('/docs/api/classes/lexical_rich_text.QuoteNode', '61d'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/classes/lexical_table.TableCellNode',
                component: ComponentCreator('/docs/api/classes/lexical_table.TableCellNode', '0c6'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/classes/lexical_table.TableNode',
                component: ComponentCreator('/docs/api/classes/lexical_table.TableNode', '151'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/classes/lexical_table.TableObserver',
                component: ComponentCreator('/docs/api/classes/lexical_table.TableObserver', '72d'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/classes/lexical_table.TableRowNode',
                component: ComponentCreator('/docs/api/classes/lexical_table.TableRowNode', 'e0f'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/classes/lexical_table.TableSelection',
                component: ComponentCreator('/docs/api/classes/lexical_table.TableSelection', '66e'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/classes/lexical.ArtificialNode__DO_NOT_USE',
                component: ComponentCreator('/docs/api/classes/lexical.ArtificialNode__DO_NOT_USE', '882'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/classes/lexical.DecoratorNode',
                component: ComponentCreator('/docs/api/classes/lexical.DecoratorNode', 'f00'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/classes/lexical.EditorState',
                component: ComponentCreator('/docs/api/classes/lexical.EditorState', '0e0'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/classes/lexical.ElementNode',
                component: ComponentCreator('/docs/api/classes/lexical.ElementNode', 'fa5'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/classes/lexical.LexicalEditor',
                component: ComponentCreator('/docs/api/classes/lexical.LexicalEditor', 'a77'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/classes/lexical.LexicalNode',
                component: ComponentCreator('/docs/api/classes/lexical.LexicalNode', '2de'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/classes/lexical.LineBreakNode',
                component: ComponentCreator('/docs/api/classes/lexical.LineBreakNode', 'f97'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/classes/lexical.NodeSelection',
                component: ComponentCreator('/docs/api/classes/lexical.NodeSelection', 'd38'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/classes/lexical.ParagraphNode',
                component: ComponentCreator('/docs/api/classes/lexical.ParagraphNode', 'c63'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/classes/lexical.Point',
                component: ComponentCreator('/docs/api/classes/lexical.Point', '0bf'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/classes/lexical.RangeSelection',
                component: ComponentCreator('/docs/api/classes/lexical.RangeSelection', 'de1'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/classes/lexical.RootNode',
                component: ComponentCreator('/docs/api/classes/lexical.RootNode', 'a3e'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/classes/lexical.TabNode',
                component: ComponentCreator('/docs/api/classes/lexical.TabNode', 'b7c'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/classes/lexical.TextNode',
                component: ComponentCreator('/docs/api/classes/lexical.TextNode', '3c3'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/interfaces/lexical_file.SerializedDocument',
                component: ComponentCreator('/docs/api/interfaces/lexical_file.SerializedDocument', '831'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/interfaces/lexical_react_LexicalAutoEmbedPlugin.EmbedConfig',
                component: ComponentCreator('/docs/api/interfaces/lexical_react_LexicalAutoEmbedPlugin.EmbedConfig', '031'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/interfaces/lexical_yjs.Provider',
                component: ComponentCreator('/docs/api/interfaces/lexical_yjs.Provider', 'fc3'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/interfaces/lexical.BaseSelection',
                component: ComponentCreator('/docs/api/interfaces/lexical.BaseSelection', 'd7f'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/interfaces/lexical.EditorStateReadOptions',
                component: ComponentCreator('/docs/api/interfaces/lexical.EditorStateReadOptions', '7d0'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/interfaces/lexical.SerializedEditorState',
                component: ComponentCreator('/docs/api/interfaces/lexical.SerializedEditorState', '9d9'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules',
                component: ComponentCreator('/docs/api/modules', '9e7'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical',
                component: ComponentCreator('/docs/api/modules/lexical', '1e5'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_clipboard',
                component: ComponentCreator('/docs/api/modules/lexical_clipboard', '060'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_code',
                component: ComponentCreator('/docs/api/modules/lexical_code', 'a50'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_devtools_core',
                component: ComponentCreator('/docs/api/modules/lexical_devtools_core', '24b'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_dragon',
                component: ComponentCreator('/docs/api/modules/lexical_dragon', '677'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_eslint_plugin',
                component: ComponentCreator('/docs/api/modules/lexical_eslint_plugin', '78b'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_file',
                component: ComponentCreator('/docs/api/modules/lexical_file', 'cbd'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_hashtag',
                component: ComponentCreator('/docs/api/modules/lexical_hashtag', '5b9'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_headless',
                component: ComponentCreator('/docs/api/modules/lexical_headless', '0f1'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_history',
                component: ComponentCreator('/docs/api/modules/lexical_history', '55c'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_html',
                component: ComponentCreator('/docs/api/modules/lexical_html', '28e'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_link',
                component: ComponentCreator('/docs/api/modules/lexical_link', '162'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_list',
                component: ComponentCreator('/docs/api/modules/lexical_list', 'd73'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_mark',
                component: ComponentCreator('/docs/api/modules/lexical_mark', '90b'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_markdown',
                component: ComponentCreator('/docs/api/modules/lexical_markdown', 'ca8'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_offset',
                component: ComponentCreator('/docs/api/modules/lexical_offset', 'e5a'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_overflow',
                component: ComponentCreator('/docs/api/modules/lexical_overflow', '9cb'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_plain_text',
                component: ComponentCreator('/docs/api/modules/lexical_plain_text', 'aca'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_LexicalAutoEmbedPlugin',
                component: ComponentCreator('/docs/api/modules/lexical_react_LexicalAutoEmbedPlugin', '747'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_LexicalAutoFocusPlugin',
                component: ComponentCreator('/docs/api/modules/lexical_react_LexicalAutoFocusPlugin', '07c'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_LexicalAutoLinkPlugin',
                component: ComponentCreator('/docs/api/modules/lexical_react_LexicalAutoLinkPlugin', '8c0'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_LexicalBlockWithAlignableContents',
                component: ComponentCreator('/docs/api/modules/lexical_react_LexicalBlockWithAlignableContents', '129'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_LexicalClearEditorPlugin',
                component: ComponentCreator('/docs/api/modules/lexical_react_LexicalClearEditorPlugin', '6c7'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_LexicalClickableLinkPlugin',
                component: ComponentCreator('/docs/api/modules/lexical_react_LexicalClickableLinkPlugin', 'c16'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_LexicalCollaborationContext',
                component: ComponentCreator('/docs/api/modules/lexical_react_LexicalCollaborationContext', '380'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_LexicalCollaborationPlugin',
                component: ComponentCreator('/docs/api/modules/lexical_react_LexicalCollaborationPlugin', '099'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_LexicalComposer',
                component: ComponentCreator('/docs/api/modules/lexical_react_LexicalComposer', '5c6'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_LexicalComposerContext',
                component: ComponentCreator('/docs/api/modules/lexical_react_LexicalComposerContext', '676'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_LexicalContentEditable',
                component: ComponentCreator('/docs/api/modules/lexical_react_LexicalContentEditable', '29c'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_LexicalContextMenuPlugin',
                component: ComponentCreator('/docs/api/modules/lexical_react_LexicalContextMenuPlugin', '11e'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_LexicalDecoratorBlockNode',
                component: ComponentCreator('/docs/api/modules/lexical_react_LexicalDecoratorBlockNode', 'c17'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_LexicalDraggableBlockPlugin',
                component: ComponentCreator('/docs/api/modules/lexical_react_LexicalDraggableBlockPlugin', 'e71'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_LexicalEditorRefPlugin',
                component: ComponentCreator('/docs/api/modules/lexical_react_LexicalEditorRefPlugin', '804'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_LexicalErrorBoundary',
                component: ComponentCreator('/docs/api/modules/lexical_react_LexicalErrorBoundary', '797'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_LexicalHashtagPlugin',
                component: ComponentCreator('/docs/api/modules/lexical_react_LexicalHashtagPlugin', '64b'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_LexicalHistoryPlugin',
                component: ComponentCreator('/docs/api/modules/lexical_react_LexicalHistoryPlugin', '5a3'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_LexicalHorizontalRuleNode',
                component: ComponentCreator('/docs/api/modules/lexical_react_LexicalHorizontalRuleNode', '73e'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_LexicalHorizontalRulePlugin',
                component: ComponentCreator('/docs/api/modules/lexical_react_LexicalHorizontalRulePlugin', '6ef'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_LexicalCharacterLimitPlugin',
                component: ComponentCreator('/docs/api/modules/lexical_react_LexicalCharacterLimitPlugin', '422'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_LexicalCheckListPlugin',
                component: ComponentCreator('/docs/api/modules/lexical_react_LexicalCheckListPlugin', 'f8f'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_LexicalLinkPlugin',
                component: ComponentCreator('/docs/api/modules/lexical_react_LexicalLinkPlugin', '555'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_LexicalListPlugin',
                component: ComponentCreator('/docs/api/modules/lexical_react_LexicalListPlugin', 'b10'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_LexicalMarkdownShortcutPlugin',
                component: ComponentCreator('/docs/api/modules/lexical_react_LexicalMarkdownShortcutPlugin', '1ec'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_LexicalNestedComposer',
                component: ComponentCreator('/docs/api/modules/lexical_react_LexicalNestedComposer', 'b68'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_LexicalNodeEventPlugin',
                component: ComponentCreator('/docs/api/modules/lexical_react_LexicalNodeEventPlugin', '0e9'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_LexicalNodeMenuPlugin',
                component: ComponentCreator('/docs/api/modules/lexical_react_LexicalNodeMenuPlugin', '598'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_LexicalOnChangePlugin',
                component: ComponentCreator('/docs/api/modules/lexical_react_LexicalOnChangePlugin', 'b8b'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_LexicalPlainTextPlugin',
                component: ComponentCreator('/docs/api/modules/lexical_react_LexicalPlainTextPlugin', '121'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_LexicalRichTextPlugin',
                component: ComponentCreator('/docs/api/modules/lexical_react_LexicalRichTextPlugin', '870'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_LexicalTabIndentationPlugin',
                component: ComponentCreator('/docs/api/modules/lexical_react_LexicalTabIndentationPlugin', '533'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_LexicalTableOfContents',
                component: ComponentCreator('/docs/api/modules/lexical_react_LexicalTableOfContents', 'bc4'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_LexicalTableOfContentsPlugin',
                component: ComponentCreator('/docs/api/modules/lexical_react_LexicalTableOfContentsPlugin', 'df0'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_LexicalTablePlugin',
                component: ComponentCreator('/docs/api/modules/lexical_react_LexicalTablePlugin', '1cf'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_LexicalTreeView',
                component: ComponentCreator('/docs/api/modules/lexical_react_LexicalTreeView', '298'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_LexicalTypeaheadMenuPlugin',
                component: ComponentCreator('/docs/api/modules/lexical_react_LexicalTypeaheadMenuPlugin', 'c61'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_useLexicalEditable',
                component: ComponentCreator('/docs/api/modules/lexical_react_useLexicalEditable', '6ef'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_useLexicalIsTextContentEmpty',
                component: ComponentCreator('/docs/api/modules/lexical_react_useLexicalIsTextContentEmpty', 'c71'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_useLexicalNodeSelection',
                component: ComponentCreator('/docs/api/modules/lexical_react_useLexicalNodeSelection', '09b'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_useLexicalSubscription',
                component: ComponentCreator('/docs/api/modules/lexical_react_useLexicalSubscription', 'f3e'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_react_useLexicalTextEntity',
                component: ComponentCreator('/docs/api/modules/lexical_react_useLexicalTextEntity', 'e14'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_rich_text',
                component: ComponentCreator('/docs/api/modules/lexical_rich_text', '77c'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_selection',
                component: ComponentCreator('/docs/api/modules/lexical_selection', 'a76'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_table',
                component: ComponentCreator('/docs/api/modules/lexical_table', '013'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_text',
                component: ComponentCreator('/docs/api/modules/lexical_text', '650'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_utils',
                component: ComponentCreator('/docs/api/modules/lexical_utils', '7d1'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/api/modules/lexical_yjs',
                component: ComponentCreator('/docs/api/modules/lexical_yjs', '37a'),
                exact: true,
                sidebar: "api"
              },
              {
                path: '/docs/collaboration/faq',
                component: ComponentCreator('/docs/collaboration/faq', '0ec'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/collaboration/react',
                component: ComponentCreator('/docs/collaboration/react', '0ad'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/concepts/commands',
                component: ComponentCreator('/docs/concepts/commands', 'd4f'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/concepts/dom-events',
                component: ComponentCreator('/docs/concepts/dom-events', '1d7'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/concepts/editor-state',
                component: ComponentCreator('/docs/concepts/editor-state', '3eb'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/concepts/history',
                component: ComponentCreator('/docs/concepts/history', 'b46'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/concepts/listeners',
                component: ComponentCreator('/docs/concepts/listeners', '56e'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/concepts/node-replacement',
                component: ComponentCreator('/docs/concepts/node-replacement', 'cc3'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/concepts/nodes',
                component: ComponentCreator('/docs/concepts/nodes', 'aca'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/concepts/read-only',
                component: ComponentCreator('/docs/concepts/read-only', '1f4'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/concepts/selection',
                component: ComponentCreator('/docs/concepts/selection', '9ee'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/concepts/serialization',
                component: ComponentCreator('/docs/concepts/serialization', '28d'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/concepts/transforms',
                component: ComponentCreator('/docs/concepts/transforms', 'e44'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/design',
                component: ComponentCreator('/docs/design', '006'),
                exact: true
              },
              {
                path: '/docs/error',
                component: ComponentCreator('/docs/error', '260'),
                exact: true
              },
              {
                path: '/docs/faq',
                component: ComponentCreator('/docs/faq', 'b65'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/getting-started/creating-plugin',
                component: ComponentCreator('/docs/getting-started/creating-plugin', '038'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/getting-started/devtools',
                component: ComponentCreator('/docs/getting-started/devtools', '56a'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/getting-started/quick-start',
                component: ComponentCreator('/docs/getting-started/quick-start', '599'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/getting-started/react',
                component: ComponentCreator('/docs/getting-started/react', '05f'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/getting-started/supported-browsers',
                component: ComponentCreator('/docs/getting-started/supported-browsers', '424'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/getting-started/theming',
                component: ComponentCreator('/docs/getting-started/theming', 'eb3'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/intro',
                component: ComponentCreator('/docs/intro', 'a6e'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/maintainers-guide',
                component: ComponentCreator('/docs/maintainers-guide', '34b'),
                exact: true
              },
              {
                path: '/docs/packages/lexical',
                component: ComponentCreator('/docs/packages/lexical', '6b5'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/packages/lexical-clipboard',
                component: ComponentCreator('/docs/packages/lexical-clipboard', '029'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/packages/lexical-code',
                component: ComponentCreator('/docs/packages/lexical-code', 'f58'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/packages/lexical-devtools-core',
                component: ComponentCreator('/docs/packages/lexical-devtools-core', '3f3'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/packages/lexical-dragon',
                component: ComponentCreator('/docs/packages/lexical-dragon', '896'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/packages/lexical-eslint-plugin',
                component: ComponentCreator('/docs/packages/lexical-eslint-plugin', '3ad'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/packages/lexical-file',
                component: ComponentCreator('/docs/packages/lexical-file', '487'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/packages/lexical-hashtag',
                component: ComponentCreator('/docs/packages/lexical-hashtag', '0ab'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/packages/lexical-headless',
                component: ComponentCreator('/docs/packages/lexical-headless', '8c7'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/packages/lexical-history',
                component: ComponentCreator('/docs/packages/lexical-history', '239'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/packages/lexical-html',
                component: ComponentCreator('/docs/packages/lexical-html', 'bd7'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/packages/lexical-link',
                component: ComponentCreator('/docs/packages/lexical-link', '3cc'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/packages/lexical-list',
                component: ComponentCreator('/docs/packages/lexical-list', '994'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/packages/lexical-mark',
                component: ComponentCreator('/docs/packages/lexical-mark', 'dfa'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/packages/lexical-markdown',
                component: ComponentCreator('/docs/packages/lexical-markdown', 'a38'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/packages/lexical-offset',
                component: ComponentCreator('/docs/packages/lexical-offset', '0d5'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/packages/lexical-overflow',
                component: ComponentCreator('/docs/packages/lexical-overflow', 'fff'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/packages/lexical-plain-text',
                component: ComponentCreator('/docs/packages/lexical-plain-text', '2e0'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/packages/lexical-react',
                component: ComponentCreator('/docs/packages/lexical-react', '8c2'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/packages/lexical-rich-text',
                component: ComponentCreator('/docs/packages/lexical-rich-text', 'aa6'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/packages/lexical-selection',
                component: ComponentCreator('/docs/packages/lexical-selection', 'c12'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/packages/lexical-table',
                component: ComponentCreator('/docs/packages/lexical-table', 'a7d'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/packages/lexical-text',
                component: ComponentCreator('/docs/packages/lexical-text', 'fa5'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/packages/lexical-utils',
                component: ComponentCreator('/docs/packages/lexical-utils', 'b43'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/packages/lexical-yjs',
                component: ComponentCreator('/docs/packages/lexical-yjs', 'eec'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/react/',
                component: ComponentCreator('/docs/react/', '90e'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/react/create_plugin',
                component: ComponentCreator('/docs/react/create_plugin', '29f'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/react/faq',
                component: ComponentCreator('/docs/react/faq', '7a3'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/react/plugins',
                component: ComponentCreator('/docs/react/plugins', '3a2'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/docs/testing',
                component: ComponentCreator('/docs/testing', '0d9'),
                exact: true
              }
            ]
          }
        ]
      }
    ]
  },
  {
    path: '/',
    component: ComponentCreator('/', '2e1'),
    exact: true
  },
  {
    path: '*',
    component: ComponentCreator('*'),
  },
];
