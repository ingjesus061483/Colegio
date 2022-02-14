﻿using Factory;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web.Mvc;
using System.Data;

namespace ColegioWeb
{
    public abstract  class Utilities
    {
        public static string App_Name = "Tienda virtual";
        public static string url;
        public static  DateTime GetFinalDate(DateTime fechainicio, Curso  curso)
        {
            DateTime fechaFin =DateTime .Now;
            int duracion = curso.Duracion;
            switch (curso.UnidadTiempo)
            {
                case 1:
                    {
                        fechaFin = fechainicio.AddDays(duracion);
                        break;
                    }
                case 2:
                    {
                        fechaFin = fechainicio.AddMonths(duracion);
                        break;

                    }
                case 3:
                    {
                        fechaFin = fechainicio.AddYears(duracion);
                        break;
                    }
            }
            return fechaFin;
        }
        public static SelectList GetSelectList(DataTable table)
        {
            List<SelectListItem> result = new List<SelectListItem>();
            try
            {
                foreach (DataRow row in table .Rows )
                {
                    SelectListItem item = new SelectListItem
                    {
                        Text = row["nombre"].ToString(),
                        Value = row["id"].ToString()
                    };
                    result.Add(item);


                }
            }
            catch
            {
                result = new List<SelectListItem>();
            }

            return new SelectList(result, "Value", "Text");
        }

        public static async Task<List<T>> GetListDataAPIAsync<T>()
        {
            try
            {
                var list = new List<T>();
                using (var httpClient = new HttpClient())
                {
                    httpClient.Timeout = TimeSpan.FromMinutes(30);
                    using (var response = await httpClient.GetAsync(url))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        if (apiResponse.Contains("Error"))
                        {
                            throw new Exception(apiResponse);
                        }
                        list = JsonConvert.DeserializeObject<List<T>>(apiResponse);


                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                Error err = JsonConvert.DeserializeObject<Error>(ex.Message);
                throw new Exception(err.ExceptionMessage);
            }
        }

        public static string Encriptar(string cadenaAencriptar)
        {
            string result = String.Empty;
            byte[] encryted = Encoding.Unicode.GetBytes(cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }
        public static async Task<T> GetDataAPIAsync<T>()
        {
            try
            {
                T data;
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync(url))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        if (apiResponse.Contains("Error"))
                        {
                            throw new Exception(apiResponse);
                        }
                        if (typeof(T) == typeof(string))
                        {
                            return (T)(object)apiResponse;
                        }
                        data = JsonConvert.DeserializeObject<T>(apiResponse);
                    }
                }
                return data;
            }
            catch (Exception ex)
            {
                Error err = JsonConvert.DeserializeObject<Error>(ex.Message);
                throw new Exception(err.ExceptionMessage);
            }
        }

        public static async Task<string> PostDataAPIAsync<T>(T data)
        {
            try
            {
                var apiResponse = string.Empty;
                using (var httpClient = new HttpClient())
                {
                    StringContent content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
                    using (var response = await httpClient.PostAsync(url, content))
                    {
                        apiResponse = await response.Content.ReadAsStringAsync();
                        if (apiResponse.Contains("Error"))
                        {
                            throw new Exception(apiResponse);
                        }
                    }
                }

                return apiResponse;
            }
            catch (Exception ex)
            {
                Error err = JsonConvert.DeserializeObject<Error>(ex.Message);
                throw new Exception(err.ExceptionMessage);
            }
        }

        public static async Task<string> PUTDataAPIAsync<T>(T data)
        {
            var apiResponse = string.Empty;
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PutAsync(url, content))
                {
                    apiResponse = await response.Content.ReadAsStringAsync();
                }
            }

            return apiResponse;

        }
        public static async Task<string> DeleteDataAPIAsync()
        {
            try
            {
                var apiResponse = string.Empty;
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.DeleteAsync(url))
                    {
                        apiResponse = await response.Content.ReadAsStringAsync();
                    }
                }

                return apiResponse;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static async Task<string> PUTDataAPIAsync()
        {
            try
            {
                var apiResponse = string.Empty;
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.PutAsync(url, null))
                    {
                        apiResponse = await response.Content.ReadAsStringAsync();
                    }
                }

                return apiResponse;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
