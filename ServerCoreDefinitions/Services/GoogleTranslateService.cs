﻿using AutoResxTranslator;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web;

namespace EasyITCenter.Services {

	public class GoogleTranslateService {
		private const string RequestUserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:91.0) Gecko/20100101 Firefox/91.0";
		//private const string RequestGoogleTranslatorUrl =  "https://translate.googleapis.com/translate_a/single?client=gtx&sl=auto&tl={0}&hl={1}&dt=t&dt=bd&dj=1&source=bubble&q={2}";
		private static readonly string RequestGoogleTranslatorUrl = DbOperations.GetServerParameterLists("TranslatorApi").Value;

        public delegate void TranslateCallBack(bool succeed, string result);
		public static void TranslateAsync(
			string text,
			string sourceLng,
			string destLng,
			string textTranslatorUrlKey,
			TranslateCallBack callBack)
		{
			var request = CreateWebRequest(text, sourceLng, destLng, textTranslatorUrlKey);
			request.BeginGetResponse(
				TranslateRequestCallBack,
				new KeyValuePair<WebRequest, TranslateCallBack>(request, callBack));
		}

		public static bool Translate(
			string text,
			string sourceLng,
			string destLng,
			string textTranslatorUrlKey,
			out string result)
		{
			var request = CreateWebRequest(text, sourceLng, destLng, textTranslatorUrlKey);
			try
			{
				var response = (HttpWebResponse)request.GetResponse();

				if (response.StatusCode != HttpStatusCode.OK)
				{
					result = "Response is failed with code: " + response.StatusCode;
					return false;
				}

				using (var stream = response.GetResponseStream())
				{
					var succeed = ReadGoogleTranslatedResult(stream, out var output);
					result = output;
					return succeed;
				}
			}
			catch (Exception ex)
			{
				result = ex.Message;
				return false;
			}
		}

		static WebRequest CreateWebRequest(
			string text,
			string lngSourceCode,
			string lngDestinationCode,
			string textTranslatorUrlKey)
		{
			text = HttpUtility.UrlEncode(text);

			var url = string.Format(RequestGoogleTranslatorUrl, lngSourceCode, lngDestinationCode, text);


			var create = (HttpWebRequest)WebRequest.Create(url);
			create.UserAgent = RequestUserAgent;
			create.Timeout = 50 * 1000;
			return create;
		}

		private static void TranslateRequestCallBack(IAsyncResult ar)
		{
			var pair = (KeyValuePair<WebRequest, TranslateCallBack>)ar.AsyncState;
			var request = pair.Key;
			var callback = pair.Value;
			HttpWebResponse response = null;
			try
			{
				response = (HttpWebResponse)request.EndGetResponse(ar);
				if (response.StatusCode != HttpStatusCode.OK)
				{
					callback(false, "Response is failed with code: " + response.StatusCode);
					return;
				}

				using (var stream = response.GetResponseStream())
				{
					string output;
					var succeed = ReadGoogleTranslatedResult(stream, out output);

					callback(succeed, output);
				}
			}
			catch (Exception ex)
			{
				callback(false, "Request failed.\r\n" + ex.Message);
			}
			finally
			{
				response?.Close();
			}
		}


		static bool ReadGoogleTranslatedResult(Stream rawdata, out string result)
		{
			string text;
			using (var reader = new StreamReader(rawdata, Encoding.UTF8))
			{
				text = reader.ReadToEnd();
			}

			try
			{
				dynamic obj = SimpleJson.DeserializeObject(text);

                string? final = "";
				int lines = obj[0].Count;
				for (int i = 0; i < lines; i++)
				{
					final += (obj[0][i][0]).ToString();
				}
				result = final;
				return true;
			}
			catch (Exception ex)
			{
				result = ex.Message;
				return false;
			}
		}

	}
}
