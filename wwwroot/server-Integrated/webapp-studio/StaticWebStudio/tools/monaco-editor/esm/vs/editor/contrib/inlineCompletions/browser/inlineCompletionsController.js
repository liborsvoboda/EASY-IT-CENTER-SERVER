/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __param = (this && this.__param) || function (paramIndex, decorator) {
    return function (target, key) { decorator(target, key, paramIndex); }
};
var InlineCompletionsController_1;
import { alert } from '../../../../base/browser/ui/aria/aria.js';
import { Event } from '../../../../base/common/event.js';
import { Disposable, toDisposable } from '../../../../base/common/lifecycle.js';
import { autorun, constObservable, disposableObservableValue, observableFromEvent, observableValue, transaction } from '../../../../base/common/observable.js';
import { CoreEditingCommands } from '../../../browser/coreCommands.js';
import { Position } from '../../../common/core/position.js';
import { ILanguageFeatureDebounceService } from '../../../common/services/languageFeatureDebounce.js';
import { ILanguageFeaturesService } from '../../../common/services/languageFeatures.js';
import { inlineSuggestCommitId } from './commandIds.js';
import { GhostTextWidget } from './ghostTextWidget.js';
import { InlineCompletionContextKeys } from './inlineCompletionContextKeys.js';
import { InlineCompletionsHintsWidget, InlineSuggestionHintsContentWidget } from './inlineCompletionsHintsWidget.js';
import { InlineCompletionsModel, VersionIdChangeReason } from './inlineCompletionsModel.js';
import { SuggestWidgetAdaptor } from './suggestWidgetInlineCompletionProvider.js';
import { localize } from '../../../../nls.js';
import { AudioCue, IAudioCueService } from '../../../../platform/audioCues/browser/audioCueService.js';
import { ICommandService } from '../../../../platform/commands/common/commands.js';
import { IConfigurationService } from '../../../../platform/configuration/common/configuration.js';
import { IContextKeyService } from '../../../../platform/contextkey/common/contextkey.js';
import { IInstantiationService } from '../../../../platform/instantiation/common/instantiation.js';
import { IKeybindingService } from '../../../../platform/keybinding/common/keybinding.js';
let InlineCompletionsController = InlineCompletionsController_1 = class InlineCompletionsController extends Disposable {
    static get(editor) {
        return editor.getContribution(InlineCompletionsController_1.ID);
    }
    constructor(editor, instantiationService, contextKeyService, configurationService, commandService, debounceService, languageFeaturesService, audioCueService, _keybindingService) {
        super();
        this.editor = editor;
        this.instantiationService = instantiationService;
        this.contextKeyService = contextKeyService;
        this.configurationService = configurationService;
        this.commandService = commandService;
        this.debounceService = debounceService;
        this.languageFeaturesService = languageFeaturesService;
        this.audioCueService = audioCueService;
        this._keybindingService = _keybindingService;
        this.model = disposableObservableValue('inlineCompletionModel', undefined);
        this.textModelVersionId = observableValue(this, -1);
        this.cursorPosition = observableValue(this, new Position(1, 1));
        this.suggestWidgetAdaptor = this._register(new SuggestWidgetAdaptor(this.editor, () => { var _a, _b; return (_b = (_a = this.model.get()) === null || _a === void 0 ? void 0 : _a.selectedInlineCompletion.get()) === null || _b === void 0 ? void 0 : _b.toSingleTextEdit(undefined); }, (tx) => this.updateObservables(tx, VersionIdChangeReason.Other), (item) => {
            transaction(tx => {
                var _a;
                /** @description handleSuggestAccepted */
                this.updateObservables(tx, VersionIdChangeReason.Other);
                (_a = this.model.get()) === null || _a === void 0 ? void 0 : _a.handleSuggestAccepted(item);
            });
        }));
        this._enabled = observableFromEvent(this.editor.onDidChangeConfiguration, () => this.editor.getOption(61 /* EditorOption.inlineSuggest */).enabled);
        this.ghostTextWidget = this._register(this.instantiationService.createInstance(GhostTextWidget, this.editor, {
            ghostText: this.model.map((v, reader) => v === null || v === void 0 ? void 0 : v.ghostText.read(reader)),
            minReservedLineCount: constObservable(0),
            targetTextModel: this.model.map(v => v === null || v === void 0 ? void 0 : v.textModel),
        }));
        this._debounceValue = this.debounceService.for(this.languageFeaturesService.inlineCompletionsProvider, 'InlineCompletionsDebounce', { min: 50, max: 50 });
        this._register(new InlineCompletionContextKeys(this.contextKeyService, this.model));
        this._register(Event.runAndSubscribe(editor.onDidChangeModel, () => transaction(tx => {
            /** @description onDidChangeModel */
            this.model.set(undefined, tx);
            this.updateObservables(tx, VersionIdChangeReason.Other);
            const textModel = editor.getModel();
            if (textModel) {
                const model = instantiationService.createInstance(InlineCompletionsModel, textModel, this.suggestWidgetAdaptor.selectedItem, this.cursorPosition, this.textModelVersionId, this._debounceValue, observableFromEvent(editor.onDidChangeConfiguration, () => editor.getOption(116 /* EditorOption.suggest */).preview), observableFromEvent(editor.onDidChangeConfiguration, () => editor.getOption(116 /* EditorOption.suggest */).previewMode), observableFromEvent(editor.onDidChangeConfiguration, () => editor.getOption(61 /* EditorOption.inlineSuggest */).mode), this._enabled);
                this.model.set(model, tx);
            }
        })));
        const getReason = (e) => {
            var _a;
            if (e.isUndoing) {
                return VersionIdChangeReason.Undo;
            }
            if (e.isRedoing) {
                return VersionIdChangeReason.Redo;
            }
            if ((_a = this.model.get()) === null || _a === void 0 ? void 0 : _a.isAcceptingPartially) {
                return VersionIdChangeReason.AcceptWord;
            }
            return VersionIdChangeReason.Other;
        };
        this._register(editor.onDidChangeModelContent((e) => transaction(tx => 
        /** @description onDidChangeModelContent */
        this.updateObservables(tx, getReason(e)))));
        this._register(editor.onDidChangeCursorPosition(e => transaction(tx => {
            var _a;
            /** @description onDidChangeCursorPosition */
            this.updateObservables(tx, VersionIdChangeReason.Other);
            if (e.reason === 3 /* CursorChangeReason.Explicit */ || e.source === 'api') {
                (_a = this.model.get()) === null || _a === void 0 ? void 0 : _a.stop(tx);
            }
        })));
        this._register(editor.onDidType(() => transaction(tx => {
            var _a;
            /** @description onDidType */
            this.updateObservables(tx, VersionIdChangeReason.Other);
            if (this._enabled.get()) {
                (_a = this.model.get()) === null || _a === void 0 ? void 0 : _a.trigger(tx);
            }
        })));
        this._register(this.commandService.onDidExecuteCommand((e) => {
            // These commands don't trigger onDidType.
            const commands = new Set([
                CoreEditingCommands.Tab.id,
                CoreEditingCommands.DeleteLeft.id,
                CoreEditingCommands.DeleteRight.id,
                inlineSuggestCommitId,
                'acceptSelectedSuggestion',
            ]);
            if (commands.has(e.commandId) && editor.hasTextFocus() && this._enabled.get()) {
                transaction(tx => {
                    var _a;
                    /** @description onDidExecuteCommand */
                    (_a = this.model.get()) === null || _a === void 0 ? void 0 : _a.trigger(tx);
                });
            }
        }));
        this._register(this.editor.onDidBlurEditorWidget(() => {
            // This is a hidden setting very useful for debugging
            if (this.contextKeyService.getContextKeyValue('accessibleViewIsShown') || this.configurationService.getValue('editor.inlineSuggest.keepOnBlur') ||
                editor.getOption(61 /* EditorOption.inlineSuggest */).keepOnBlur) {
                return;
            }
            if (InlineSuggestionHintsContentWidget.dropDownVisible) {
                return;
            }
            transaction(tx => {
                var _a;
                /** @description onDidBlurEditorWidget */
                (_a = this.model.get()) === null || _a === void 0 ? void 0 : _a.stop(tx);
            });
        }));
        this._register(autorun(reader => {
            var _a;
            /** @description forceRenderingAbove */
            const state = (_a = this.model.read(reader)) === null || _a === void 0 ? void 0 : _a.state.read(reader);
            if (state === null || state === void 0 ? void 0 : state.suggestItem) {
                if (state.ghostText.lineCount >= 2) {
                    this.suggestWidgetAdaptor.forceRenderingAbove();
                }
            }
            else {
                this.suggestWidgetAdaptor.stopForceRenderingAbove();
            }
        }));
        this._register(toDisposable(() => {
            this.suggestWidgetAdaptor.stopForceRenderingAbove();
        }));
        let lastInlineCompletionId = undefined;
        this._register(autorun(reader => {
            /** @description play audio cue & read suggestion */
            const model = this.model.read(reader);
            const state = model === null || model === void 0 ? void 0 : model.state.read(reader);
            if (!model || !state || !state.inlineCompletion) {
                lastInlineCompletionId = undefined;
                return;
            }
            if (state.inlineCompletion.semanticId !== lastInlineCompletionId) {
                lastInlineCompletionId = state.inlineCompletion.semanticId;
                const lineText = model.textModel.getLineContent(state.ghostText.lineNumber);
                this.audioCueService.playAudioCue(AudioCue.inlineSuggestion).then(() => {
                    if (this.editor.getOption(7 /* EditorOption.screenReaderAnnounceInlineSuggestion */)) {
                        this.provideScreenReaderUpdate(state.ghostText.renderForScreenReader(lineText));
                    }
                });
            }
        }));
        this._register(new InlineCompletionsHintsWidget(this.editor, this.model, this.instantiationService));
        this._register(this.configurationService.onDidChangeConfiguration(e => {
            if (e.affectsConfiguration('accessibility.verbosity.inlineCompletions')) {
                this.editor.updateOptions({ inlineCompletionsAccessibilityVerbose: this.configurationService.getValue('accessibility.verbosity.inlineCompletions') });
            }
        }));
        this.editor.updateOptions({ inlineCompletionsAccessibilityVerbose: this.configurationService.getValue('accessibility.verbosity.inlineCompletions') });
    }
    provideScreenReaderUpdate(content) {
        const accessibleViewShowing = this.contextKeyService.getContextKeyValue('accessibleViewIsShown');
        const accessibleViewKeybinding = this._keybindingService.lookupKeybinding('editor.action.accessibleView');
        let hint;
        if (!accessibleViewShowing && accessibleViewKeybinding && this.editor.getOption(146 /* EditorOption.inlineCompletionsAccessibilityVerbose */)) {
            hint = localize('showAccessibleViewHint', "Inspect this in the accessible view ({0})", accessibleViewKeybinding.getAriaLabel());
        }
        hint ? alert(content + ', ' + hint) : alert(content);
    }
    /**
     * Copies over the relevant state from the text model to observables.
     * This solves all kind of eventing issues, as we make sure we always operate on the latest state,
     * regardless of who calls into us.
     */
    updateObservables(tx, changeReason) {
        var _a, _b;
        const newModel = this.editor.getModel();
        this.textModelVersionId.set((_a = newModel === null || newModel === void 0 ? void 0 : newModel.getVersionId()) !== null && _a !== void 0 ? _a : -1, tx, changeReason);
        this.cursorPosition.set((_b = this.editor.getPosition()) !== null && _b !== void 0 ? _b : new Position(1, 1), tx);
    }
    shouldShowHoverAt(range) {
        var _a;
        const ghostText = (_a = this.model.get()) === null || _a === void 0 ? void 0 : _a.ghostText.get();
        if (ghostText) {
            return ghostText.parts.some(p => range.containsPosition(new Position(ghostText.lineNumber, p.column)));
        }
        return false;
    }
    shouldShowHoverAtViewZone(viewZoneId) {
        return this.ghostTextWidget.ownsViewZone(viewZoneId);
    }
};
InlineCompletionsController.ID = 'editor.contrib.inlineCompletionsController';
InlineCompletionsController = InlineCompletionsController_1 = __decorate([
    __param(1, IInstantiationService),
    __param(2, IContextKeyService),
    __param(3, IConfigurationService),
    __param(4, ICommandService),
    __param(5, ILanguageFeatureDebounceService),
    __param(6, ILanguageFeaturesService),
    __param(7, IAudioCueService),
    __param(8, IKeybindingService)
], InlineCompletionsController);
export { InlineCompletionsController };
