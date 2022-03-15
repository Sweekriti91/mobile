﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Bit.Core.Abstractions;
using Bit.Core.Utilities;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace Bit.App.Pages
{
    public partial class ScanPage : BaseContentPage
    {
        private readonly Action<string> _callback;

        private CancellationTokenSource _autofocusCts;
        private Task _continuousAutofocusTask;

        private readonly LazyResolve<ILogger> _logger = new LazyResolve<ILogger>("logger");

        public ScanPage(Action<string> callback)
        {
            _callback = callback;
            InitializeComponent();
            //_zxing.Options = new ZXing.Mobile.MobileBarcodeScanningOptions
            //{
            //    UseNativeScanning = true,
            //    PossibleFormats = new List<ZXing.BarcodeFormat> { ZXing.BarcodeFormat.QR_CODE },
            //    AutoRotate = false,
            //    TryInverted = true
            //};
            if (Device.RuntimePlatform == Device.Android)
            {
                ToolbarItems.RemoveAt(0);
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //_zxing.IsScanning = true;

            //// Fix for Autofocus, now it's done every 2 seconds so that the user does't have to do it
            //// https://github.com/Redth/ZXing.Net.Mobile/issues/414
            //_autofocusCts?.Cancel();
            //_autofocusCts = new CancellationTokenSource(TimeSpan.FromMinutes(3));

            //var autofocusCts = _autofocusCts;
            //_continuousAutofocusTask = Task.Run(async () =>
            //{
            //    try
            //    {
            //        while (!autofocusCts.IsCancellationRequested)
            //        {
            //            await Task.Delay(TimeSpan.FromSeconds(2), autofocusCts.Token);
            //            Device.BeginInvokeOnMainThread(() =>
            //            {
            //                if (!autofocusCts.IsCancellationRequested)
            //                {
            //                    _zxing.AutoFocus();
            //                }
            //            });
            //        }
            //    }
            //    catch (TaskCanceledException) { }
            //    catch (Exception ex)
            //    {
            //        _logger.Value.Exception(ex);
            //    }
            //}, autofocusCts.Token);
        }

        protected override async void OnDisappearing()
        {
            _autofocusCts?.Cancel();

            await _continuousAutofocusTask;
            //_zxing.IsScanning = false;

            base.OnDisappearing();
        }

        //private void OnScanResult(ZXing.Result result)
        //{
        //    // Stop analysis until we navigate away so we don't keep reading barcodes
        //    _zxing.IsAnalyzing = false;
        //    _zxing.IsScanning = false;
        //    var text = result?.Text;
        //    if (!string.IsNullOrWhiteSpace(text))
        //    {
        //        if (text.StartsWith("otpauth://totp"))
        //        {
        //            _callback(text);
        //            return;
        //        }
        //        else if (Uri.TryCreate(text, UriKind.Absolute, out Uri uri) &&
        //            !string.IsNullOrWhiteSpace(uri?.Query))
        //        {
        //            var queryParts = uri.Query.Substring(1).ToLowerInvariant().Split('&');
        //            foreach (var part in queryParts)
        //            {
        //                if (part.StartsWith("secret="))
        //                {
        //                    _callback(part.Substring(7)?.ToUpperInvariant());
        //                    return;
        //                }
        //            }
        //        }
        //    }
        //    _callback(null);
        //}

        private async void Close_Clicked(object sender, System.EventArgs e)
        {
            if (DoOnce())
            {
                await Navigation.PopModalAsync();
            }
        }
    }
}
