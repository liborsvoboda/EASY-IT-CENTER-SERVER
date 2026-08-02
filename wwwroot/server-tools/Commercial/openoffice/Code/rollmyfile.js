/*!
	rollMyFile API Copyright 2014-2016 (c) rollApp, Inc.

	Licensed under the Apache License, Version 2.0 (the "License");
	you may not use this file except in compliance with the License.
	You may obtain a copy of the License at

		http://www.apache.org/licenses/LICENSE-2.0

	Unless required by applicable law or agreed to in writing, software
	distributed under the License is distributed on an "AS IS" BASIS,
	WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
	See the License for the specific language governing permissions and
	limitations under the License.
*/
'use strict';

/* global define */

(function (root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define([], function () {
      return factory();
    });
  } else {
    // Browser globals
    root.RollMyFile = factory();
  }
}(window, function () {
  var API_HOST = 'https://api.rollapp.com';
  var API_BASE = '/1/rollmyfile';

  var ENDPOINT_EXTENSIONS  = '/extensions';
  var ENDPOINT_BROWSER     = '/browser';
  var ENDPOINT_OPEN        = '/open';
  var ENDPOINT_EDIT        = '/edit';

  var ERROR_PREFIX         = 'RollMyFile: ';

  /**
   * - API access key setup
   * - Check for browser compatibility
   * - Load supported file extensions
   *
   * @param {string} key
   * @param {function} [onInitComplete]
   * @constructor
   */
  function RollMyFile(key, onInitComplete) {
    this._apiHost = API_HOST;

    if (!key) {
      throw ERROR_PREFIX + 'Required argument "key" is missing';
    }

    this._key = key;

    this._initComp = onInitComplete || function () {};

    this._initExt();
    this._initBrSup();
  }

  RollMyFile.prototype = {
    /**
     * @type {string}
     */
    _apiHost: null,

    /**
     * @type {string}
     */
    _key: null,

    /**
     * @type {Object.<string, number>}
     */
    _ext: null,

    /**
     * @type {Array.<string>}
     */
    _extL: null,

    /**
     * @type {boolean}
     */
    _brSup: null,

    /**
     * @type {function}
     */
    _initComp: null,

    /**
     * Returns list of supported extensions
     * List example: ['.doc', '.docx', '.psd', '.ai' ... ]
     *
     * @returns {Array}
     */
    getSupportedExtensions: function () {
      if (this._extL === null) {
        logError('getSupportedExtensions() called before initialization completed');
        return [];
      }

      return this._extL;
    },

    /**
     * Returns true if file extension is supported
     *
     * @example
     * // ...
     * if (rollMyFile.isExtensionSupported('.doc')) {
     *  rollMyFile.openFileByUrl(docUrl);
     * }
     * // ...
     * @param {string} extension
     * @returns {boolean}
     */
    isExtensionSupported: function (extension) {
      if (this._ext === null) {
        logError('isExtensionSupported() called before initialization completed');
        return false;
      }

      return !!this._ext[extension];
    },

    /**
     * Returns true if current browser is supported
     *
     * @returns {boolean}
     */
    isBrowserSupported: function () {
      if (this._brSup === null) {
        logError('isBrowserSupported() called before initialization completed');
        return false;
      }

      return this._brSup;
    },

    /**
     * Open file with rollApp application in new browser window.
     * Allowed options are:
     *   - name
     *   - app
     *
     * @param {string} url
     * @param {object} [options]
     * @param {function} [onError]
     * @param {function} [onSuccess]
     * @returns {void}
     */
    openFileByUrl: function (url, options, onError, onSuccess) {
      var that = this;
      var options = options || {};

      if (!url) {
        console.error('File URL not provided. Operation aborted.');
        return;
      }

      var openRequestUrl = this._url(ENDPOINT_OPEN) + '?file=' + encodeURIComponent(url);
      var xhr = this._req('POST', openRequestUrl);
      xhr.withCredentials = true;
      xhr.setRequestHeader('X-Rollapp-Key', this._key);

      var preparedPopup = this._prepPopup();
      xhr.onload = function () {
        that._processResponse(xhr.responseText, preparedPopup, onError, onSuccess);
      };

      xhr.onerror = function () {
        that._launchError(xhr.responseText, onError);
      };

      var postData = new FormData();
      if (options.name) {
        postData.append('filename', options.name);
      }
      if (options.app) {
        postData.append('app', options.app);
      }

      xhr.send(postData);
    },

    /**
     * Open file for editing with rollApp application in new browser window
     * Allowed options are:
     *   - accessToken
     *   - fileName
     *   - dirName
     *   - app
     *
     * @param {string} fileEndpointUrl
     * @param {object} [options]
     * @param {function} [onError]
     * @param {function} [onSuccess]
     * @returns {void}
     */
    editFile: function (fileEndpointUrl, options, onError, onSuccess) {
      var that = this;
      var options = options || {};

      if (typeof fileEndpointUrl === 'undefined' || fileEndpointUrl == '') {
        console.error('File Access Endpoint URL not provided. Operation aborted.');
        return;
      }

      var editRequestUrl = this._url(ENDPOINT_EDIT);
      var xhr = this._req('POST', editRequestUrl);
      xhr.withCredentials = true;
      xhr.setRequestHeader('X-Rollapp-Key', this._key);

      var preparedPopup = this._prepPopup();
      xhr.onload = function () {
        that._processResponse(xhr.responseText, preparedPopup, onError, onSuccess);
      };

      xhr.onerror = function () {
        that._launchError(xhr.responseText, onError);
      };

      var postData = new FormData();
      postData.append('url', fileEndpointUrl);
      if (options.fileName) {
        postData.append('filename', options.fileName);
      }
      if (options.dirName) {
        postData.append('dirname', options.dirName);
      }
      if (options.accessToken) {
        postData.append('access_token', options.accessToken);
      }
      if (options.app) {
        postData.append('app', options.app);
      }

      xhr.send(postData);
    },

    /**
     * Load from server list of supported file extensions
     *
     * @private
     * @returns {void}
     */
    _initExt: function () {
      var that = this;

      var extensionsXhr = this._req('GET', this._url(ENDPOINT_EXTENSIONS));

      extensionsXhr.onload = function () {
        /**
         * @type {{
         *   extensions: Array.<string>,
         *   success: boolean
         * }}
         */
        var result = JSON.parse(extensionsXhr.responseText);
        that._ext = result.extensions;

        // Prepare list
        that._extL = [];
        for (var ext in that._ext) {
          that._extL.push(ext);
        }

        that._maybeCompl();
      };

      extensionsXhr.onerror = extensionsXhr.ontimeout = function () {
        that._ext = {};
        that._extL = [];
        that._maybeCompl();
      };

      extensionsXhr.send();
    },

    /**
     * Check with server browser support
     *
     * @private
     * @returns {void}
     */
    _initBrSup: function () {
      var that = this;

      var browserXhr = this._req('GET', this._url(ENDPOINT_BROWSER));

      browserXhr.onload = function () {
        /**
         * @type {{
         *   supported: boolean,
         *   success: boolean
         * }}
         */
        var result = JSON.parse(browserXhr.responseText);
        that._brSup = result.supported;

        that._maybeCompl();
      };

      browserXhr.onerror = browserXhr.ontimeout = function () {
        that._brSup = false;
        that._maybeCompl();
      };

      browserXhr.send();
    },

    /**
     * API endpoint url
     *
     * @param {string} endpoint
     * @returns {string}
     * @private
     */
    _url: function (endpoint) {
      return this._apiHost + API_BASE + endpoint;
    },

    /**
     * Creates CORS request object
     *
     * @param {string} method
     * @param {string} url
     * @returns {XMLHttpRequest}
     * @private
     */
    _req: function (method, url) {

      var xhr = null;
      if (typeof XDomainRequest !== 'undefined') {
        // IE 8,9 handle CORS via XDomainRequest
        xhr = new XDomainRequest();
        xhr.open(method, url);
      } else {
        xhr = new XMLHttpRequest();
        xhr.open(method, url, true);
      }

      return xhr;
    },

    /**
     * Calls init complete handler if all data received
     *
     * @private
     */
    _maybeCompl: function () {
      if (this._ext && this._brSup) {
        this._initComp();
      }
    },

    /**
     * Open browser window
     *
     * @param {number} [width]
     * @param {number} [height]
     * @returns {Window}
     * @private
     */
    _prepPopup: function (width, height) {
      width = width || 900;
      height = height || 600;

      var popup = window.open(
        '',
        '_blank',
        'menubar=no,location=no,resizable=yes,scrollbars=no,status=no,' +
          'width=' + width + ',height=' + height
      );
      popup.title = 'Application is loading to open the file';

      return popup;
    },

    /**
     * Process launch error
     *
     * @param {string} responseText
     * @param {function} [onError]
     * @private
     */
    _launchError: function (responseText, onError) {
      if (onError) {
        onError();
      }

      var errorMessage = 'Unexpected error';
      try {
        var response = JSON.parse(responseText);
        if (response && response.message) {
          errorMessage = response.message;
        }
      } catch (e) {
        errorMessage = 'Unexpected error (unparsable response)';
      }

      logError('Failed to open file: ' + errorMessage);
    },

    /**
     * Process launch response
     *
     * @param {string} responseText
     * @param {Window} preparedPopup
     * @param {function} [onError]
     * @param {function} [onSuccess]
     * @private
     */
    _processResponse: function (responseText, preparedPopup, onError, onSuccess) {
      // Disable camelcase for response keys
      /* jshint camelcase: false */

      try {
        /**
         * @type {{
         *   session_url: string,
         *   success: boolean
         * }}
         */
        var response = JSON.parse(responseText);

        if (response &&
          response.success &&
          response.session_url) {
          preparedPopup.location.href = response.session_url;

          if (onSuccess) {
            onSuccess();
          }
        } else {
          preparedPopup.close();
          this._launchError(responseText, onError);
        }

      } catch (e) {
        preparedPopup.close();
        this._launchError('', onError);
      }
    }
  };

  /**
   * Log to console or throw exception
   */
  function logError (message) {
    message = ERROR_PREFIX + message;

    var consoleErrorFunc = console.error || console.log;
    if (consoleErrorFunc) {
      consoleErrorFunc.call(console, message);
      return;
    }

    throw message;
  }

  return RollMyFile;
}));

