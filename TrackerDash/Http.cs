using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.IO;

namespace TrackerHelper
{
    public class ResultModel
    {
        private string RM_ErrorMessage = string.Empty;
        private bool RM_IsSuccess = false;
        private string RM_Results = string.Empty;

        public string ErrorMessage
        {
            get { return RM_ErrorMessage; }
            set { RM_ErrorMessage = value; }
        }
        public bool IsSuccess
        {
            get { return RM_IsSuccess; }
            set { RM_IsSuccess = value; }
        }
        public string Results
        {
            get { return RM_Results; }
            set { RM_Results = value; }
        }
    }

    class Http
    {
        CookieContainer cookies = new CookieContainer();

        #region Post - blank
        public void Post(string url, string data)//создаём метод с двумя аргументами url и data
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);//создаём экзепляр класса HttpWebRequest, req
            req.Method = "POST"; // выбираем метод запроса 
            req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8"; // добавляем заголовок и его значение
            req.CookieContainer = cookies; // прикрепляем к запросу куки
            req.Headers.Add("DNT", "1");// добавляем заголовок и его значение
            req.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:17.0) Gecko/20100101 Firefox/17.0"; // можно выбрать другой UserAgent opera, chrome, IE
            req.Referer = "http://www.ucs.ru/"; // от куда мы пришли
            req.ContentType = "application/x-www-form-urlencoded"; // определяет тип документа для ответа, так же есть multipart
            using (var requestStream = req.GetRequestStream())//отправляем поток данных
            using (var sw = new StreamWriter(requestStream)) //создаём переменную в которой будет храниться запрос
            {
                sw.Write(data);//записываем в поток данные
            }

            using (var responseStream = req.GetResponse().GetResponseStream())//возвращаем поток данных
            using (var sr = new StreamReader(responseStream))//переменная в которой храниться ответ
            {
                var result = sr.ReadToEnd();//считывем ответ в переменную
                using (var sw = new StreamWriter("page.html", false, Encoding.GetEncoding(1251)))//false значит что файл будет перезаписываться каждый раз, и указываем кодировку ту что была на сайте
                    sw.Write(result);//записываем
            }
        }
        #endregion

        #region Get
        public static ResultModel Get(string url)
        {
            var model = new ResultModel();

            HttpWebResponse resp = null;

            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                req.Method = "GET";
                req.Timeout = 45000;
                resp = (HttpWebResponse)req.GetResponse();
                if (resp.StatusCode == HttpStatusCode.OK)
                {
                    model.IsSuccess = true;
                    Stream receiveStream = resp.GetResponseStream();
                    using (StreamReader sr = new StreamReader(receiveStream, Encoding.UTF8))
                    {
                        model.Results = sr.ReadToEnd();
                    }
                }
                else
                {
                    Stream receiveStream = resp.GetResponseStream();
                    using (StreamReader sr = new StreamReader(receiveStream, Encoding.UTF8))
                    {
                        model.ErrorMessage = sr.ReadToEnd();
                    }
                }
            }
            catch (ArgumentException ex)
            {
                model.ErrorMessage = string.Format("http_get :: HTTP_ERROR :: The second HttpWebRequest object has raised an Argument Exception as 'Connection' Property is set to 'Close' :: {0}", ex.Message);
            }
            catch (WebException ex)
            {
                model.ErrorMessage = string.Format("http_get:: HTTP_ERROR :: WebException raised! :: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                model.ErrorMessage = string.Format("http_get :: HTTP_ERROR :: Exception raised! :: {0}", ex.Message);
            }
            if (resp != null)
                resp.Close();

            return model;
        }

        #endregion

        #region Put
        public static ResultModel Put(string url, string DataToPut)
        {
            var model = new ResultModel();
            
            HttpWebResponse resp = null;

            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                req.Method = "PUT";
                req.Timeout = 45000;
                req.ContentType = "application/xml";
                byte[] SendData = Encoding.UTF8.GetBytes(DataToPut);
                req.ContentLength = SendData.Length;
                using (Stream reqStream = req.GetRequestStream())
                {
                    reqStream.Write(SendData, 0, SendData.Length);
                }
                var s = req.HaveResponse;
                resp = (HttpWebResponse)req.GetResponse();
                if (resp.StatusCode == HttpStatusCode.OK)
                {
                    model.IsSuccess = true;
                    Stream receiveStream = resp.GetResponseStream();
                    using (StreamReader sr = new StreamReader(receiveStream, Encoding.UTF8))
                    {
                        model.Results = sr.ReadToEnd();
                    }
                }
                else
                {
                    Stream receiveStream = resp.GetResponseStream();
                    using (StreamReader sr = new StreamReader(receiveStream, Encoding.UTF8))
                    {
                        model.ErrorMessage = sr.ReadToEnd();
                    }
                }
            }
            catch (ArgumentException ex)
            {
                model.ErrorMessage = string.Format("http_put :: HTTP_ERROR :: The second HttpWebRequest object has raised an Argument Exception as 'Connection' Property is set to 'Close' :: {0}", ex.Message);
            }
            catch (WebException ex)
            {
                model.ErrorMessage = string.Format("http_put :: HTTP_ERROR :: WebException raised! :: {0}", ex.ToString());
            }
            catch (Exception ex)
            {
                model.ErrorMessage = string.Format("http_put :: HTTP_ERROR :: Exception raised! :: {0}", ex.Message);
            }

            if (resp != null)
                resp.Close();

            return model;
        }
        #endregion 
    }
}