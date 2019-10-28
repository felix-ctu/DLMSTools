using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace DLMSProcessTools
{
    public class ResCategoryHelper
    {
        private List<string> _strTier2List = new List<string>();
        public List<string> Tier2List
        {
            get
            {
                return _strTier2List;
            }
            set
            {
                _strTier2List = value;
            }
        }

        private List<string> _strTier3List = new List<string>();
        public List<string> Tier3List
        {
            get
            {
                return _strTier3List;
            }
            set
            {
                _strTier3List = value;
            }
        }

        private List<string> _strTier4List = new List<string>();
        public List<string> Tier4List
        {
            get
            {
                return _strTier4List;
            }
            set
            {
                _strTier4List = value;
            }
        }

        private XmlDocument xmlDoc = new XmlDocument();

        public ResCategoryHelper()
        {
            xmlDoc.Load("ResCategory.xml");
        }

        public void showXml()
        {
            //LoadXml();
            //获取根节点  
            XmlElement rootElement = xmlDoc.DocumentElement;

            //挨个查找其下的子节点  
            foreach (XmlElement childElement in rootElement)
            {
                //分别输出子节点属性  
                _strTier2List.Add(childElement.GetAttribute("Name").ToString());
                //Console.WriteLine(childElement.GetAttribute("Name"));
                //Console.WriteLine(childElement.GetAttribute("sex"));
                //Console.WriteLine(childElement.GetAttribute("age"));

                //获取孙节点列表  
                //XmlNodeList grandsonNodes = childElement.ChildNodes;
                //foreach (XmlNode grandsonNode in grandsonNodes)
                //{
                //    //显示孙节点文本  
                //    Console.WriteLine(grandsonNode.InnerText);
                //}
            }
        }

        public void GetTier3ByTier2(string strTier2)
        {
            //LoadXml();
            XmlElement rootElement = xmlDoc.DocumentElement;
            foreach (XmlElement childElement in rootElement)
            {
                if (strTier2 == childElement.GetAttribute("Name").ToString())
                {
                    //获取孙节点列表  
                    XmlNodeList grandsonNodes = childElement.ChildNodes;
                    foreach (XmlNode grandsonNode in grandsonNodes)
                    {
                        //显示孙节点文本  
                        XmlElement grandsonelement = (XmlElement)grandsonNode;
                        _strTier3List.Add(grandsonelement.GetAttribute("Name").ToString());
                    }
                }
            }
        }

        public void GetTier4ByTier2Tier3(string strTier1, string strTier2, string strTier3)
        {
            //LoadXml();
            XmlElement rootElement = xmlDoc.DocumentElement;
            foreach (XmlElement childElement in rootElement)
            {
                if (strTier2 == childElement.GetAttribute("Name").ToString())
                {
                    //获取孙节点列表  
                    XmlNodeList grandsonNodes = childElement.ChildNodes;
                    foreach (XmlNode grandsonNode in grandsonNodes)
                    {
                        //显示孙节点文本  
                        XmlElement grandsonelement = (XmlElement)grandsonNode;
                        if (strTier3 == grandsonelement.GetAttribute("Name").ToString())
                        {
                            XmlNodeList grandgrandsonNodes = grandsonNode.ChildNodes;
                            foreach (XmlNode grandgrandsonNode in grandgrandsonNodes)
                            {
                                XmlElement grandgrandsonelement = (XmlElement)grandgrandsonNode;
                                if (grandgrandsonelement.GetAttribute("Filter").Length > 0)
                                {
                                    if (strTier1 == grandgrandsonelement.GetAttribute("Filter").ToString())
                                    {
                                        _strTier4List.Add(grandgrandsonelement.GetAttribute("Name").ToString());
                                    }
                                }
                                else
                                {
                                    _strTier4List.Add(grandgrandsonelement.GetAttribute("Name").ToString());
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
