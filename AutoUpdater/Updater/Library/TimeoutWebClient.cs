﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace Updater.Library {

	public class TimeoutWebClient : WebClient {
		private int mTimeOut = 10000;
		public int TimeOut {
			get { return mTimeOut; }
			set { mTimeOut = value; }
		}

		protected override WebRequest GetWebRequest( Uri address ) {
			WebRequest webRequest = base.GetWebRequest( address );
			webRequest.Timeout = mTimeOut;
			return webRequest;
		}
	}

}
