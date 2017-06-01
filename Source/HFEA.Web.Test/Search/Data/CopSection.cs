using HFEA.Connector.Contracts.COP;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.Test.Search.Data
{
    public class CopSection
    {
        public static COPItem Data(int section)
        {
            string data = "";

            if (section == 1)
            {
                data = data1;
            }
            else if (section == 3)
            {
                data = data3;
            }

            return JsonConvert.DeserializeObject<COPItem>(data);
        }

        private static string data1 = @"
  {
  ""description"": ""8th Edition"",
  ""copgroups"": [],
  ""copsections"": [
    {
      ""sectionumber"": ""1"",
      ""sectioname"": ""Person Responsible"",
      ""copacts"": [
        {
          ""SectionNumber"": ""Act"",
          ""Description"": ""Human Fertilisation and Embryology Act 2008"",
          ""FormatType"": ""Act"",
          ""COPVersionDatas"": [],
          ""COPReferences"": [
            {
              ""SectionNumber"": ""16"",
              ""Description"": ""Grant of licence"",
              ""FormatType"": ""Act"",
              ""COPVersionDatas"": [],
              ""COPReferences"": [
                {
                  ""SectionNumber"": ""1"",
                  ""Description"": ""The Authority may on application grant a licence to any person if the requirements of subsection (2) below are met."",
                  ""FormatType"": ""Act"",
                  ""COPVersionDatas"": [],
                  ""COPReferences"": [],
                  ""Id"": 0
                },
                {
                  ""SectionNumber"": ""2"",
                  ""Description"": ""The requirements mentioned in subsection (1) above are -"",
                  ""FormatType"": ""Act"",
                  ""COPVersionDatas"": [],
                  ""COPReferences"": [
                    {
                      ""SectionNumber"": ""a"",
                      ""Description"": ""that the application is for a licence designating an individual as the person under whose supervision the activities to be authorised by the licence are to be carried on,"",
                      ""FormatType"": ""Act"",
                      ""COPVersionDatas"": [],
                      ""COPReferences"": [],
                      ""Id"": 0
                    },
                    {
                      ""SectionNumber"": ""b"",
                      ""Description"": ""that either that individual is the applicant or - "",
                      ""FormatType"": ""Act"",
                      ""COPVersionDatas"": [],
                      ""COPReferences"": [
                        {
                          ""SectionNumber"": ""i"",
                          ""Description"": ""the application is made with the consent of that individual, and"",
                          ""FormatType"": ""Act"",
                          ""COPVersionDatas"": [],
                          ""COPReferences"": [],
                          ""Id"": 0
                        },
                        {
                          ""SectionNumber"": ""ii"",
                          ""Description"": ""the Authority is satisfied that the applicant is a suitable person to hold a licence,"",
                          ""FormatType"": ""Act"",
                          ""COPVersionDatas"": [],
                          ""COPReferences"": [],
                          ""Id"": 0
                        }
                      ],
                      ""Id"": 0
                    },
                    {
                      ""SectionNumber"": ""c"",
                      ""Description"": ""in relation to a licence under paragraph 1 or 1A of Schedule 2 or a licence under paragraph 2 of that Schedule authorising the storage of gametes or embryos intended for human application, that the individual -"",
                      ""FormatType"": ""Act"",
                      ""COPVersionDatas"": [],
                      ""COPReferences"": [
                        {
                          ""SectionNumber"": ""i"",
                          ""Description"": ""possesses a diploma, certificate or other evidence of formal qualifications in the field of medical or biological sciences, awarded on completion of a university course of study, or other course of study recognised in the United Kingdom as equivalent, or is otherwise considered by the Authority to be suitably qualified on the basis of academic qualifications in the field of nursing, and"",
                          ""FormatType"": ""Act"",
                          ""COPVersionDatas"": [],
                          ""COPReferences"": [],
                          ""Id"": 0
                        },
                        {
                          ""SectionNumber"": ""ii"",
                          ""Description"": ""has at least two years’ practical experience which is directly relevant to the activity to be authorised by the licence,"",
                          ""FormatType"": ""Act"",
                          ""COPVersionDatas"": [],
                          ""COPReferences"": [],
                          ""Id"": 0
                        }
                      ],
                      ""Id"": 0
                    },
                    {
                      ""SectionNumber"": ""d"",
                      ""Description"": ""that the Authority is satisfied that the premises in respect of which the licence is to be granted and any premises which will be relevant third party premises are suitable for the activities, and"",
                      ""FormatType"": ""Act"",
                      ""COPVersionDatas"": [],
                      ""COPReferences"": [],
                      ""Id"": 0
                    },
                    {
                      ""SectionNumber"": ""e"",
                      ""Description"": ""that all the other requirements of this Act in relation to the granting of the licence are satisfied."",
                      ""FormatType"": ""Act"",
                      ""COPVersionDatas"": [],
                      ""COPReferences"": [],
                      ""Id"": 0
                    },
                    {
                      ""SectionNumber"": ""ca"",
                      ""Description"": ""in relation to a licence under paragraph 2 of Schedule 2 authorising storage of gametes, embryos or human admixed embryos not intended for human application or a licence under paragraph 3 of that Schedule, that the Authority is satisfied that the qualifications and experience of that individual are such as are required for the supervision of the activities,"",
                      ""FormatType"": ""Act"",
                      ""COPVersionDatas"": [],
                      ""COPReferences"": [],
                      ""Id"": 0
                    },
                    {
                      ""SectionNumber"": ""cb"",
                      ""Description"": ""that the Authority is satisfied that the character of that individual is such as is required for the supervision of the activities and that the individual will discharge the duty under section 17 of this Act,"",
                      ""FormatType"": ""Act"",
                      ""COPVersionDatas"": [],
                      ""COPReferences"": [],
                      ""Id"": 0
                    }
                  ],
                  ""Id"": 0
                }
              ],
              ""Id"": 0
            },
            {
              ""SectionNumber"": ""17"",
              ""Description"": ""The person responsible"",
              ""FormatType"": ""Act"",
              ""COPVersionDatas"": [],
              ""COPReferences"": [
                {
                  ""SectionNumber"": ""1"",
                  ""Description"": ""It shall be the duty of the individual under whose supervision the activities authorised by a licence are carried on (referred to in this Act as the \""person responsible\"") to secure -"",
                  ""FormatType"": ""Act"",
                  ""COPVersionDatas"": [],
                  ""COPReferences"": [
                    {
                      ""SectionNumber"": ""a"",
                      ""Description"": ""that the other persons to whom the licence applies are of such character, and are so qualified by training and experience, as to be suitable persons to participate in the activities authorised by the licence,"",
                      ""FormatType"": ""Act"",
                      ""COPVersionDatas"": [],
                      ""COPReferences"": [],
                      ""Id"": 0
                    },
                    {
                      ""SectionNumber"": ""b"",
                      ""Description"": ""that proper equipment is used,"",
                      ""FormatType"": ""Act"",
                      ""COPVersionDatas"": [],
                      ""COPReferences"": [],
                      ""Id"": 0
                    },
                    {
                      ""SectionNumber"": ""c"",
                      ""Description"": ""that proper arrangements are made for the keeping of gametes, embryos and human admixed embryos and for the disposal of gametes, embryos or human admixed embryos that have been allowed to perish,"",
                      ""FormatType"": ""Act"",
                      ""COPVersionDatas"": [],
                      ""COPReferences"": [],
                      ""Id"": 0
                    },
                    {
                      ""SectionNumber"": ""d"",
                      ""Description"": ""that suitable practices are used in the course of the activities,"",
                      ""FormatType"": ""Act"",
                      ""COPVersionDatas"": [],
                      ""COPReferences"": [],
                      ""Id"": 0
                    },
                    {
                      ""SectionNumber"": ""e"",
                      ""Description"": ""that the conditions of the licence are complied with,"",
                      ""FormatType"": ""Act"",
                      ""COPVersionDatas"": [],
                      ""COPReferences"": [],
                      ""Id"": 0
                    },
                    {
                      ""SectionNumber"": ""f"",
                      ""Description"": ""that conditions of third party agreements relating to the procurement, testing, processing or distribution of gametes or embryos are complied with, and"",
                      ""FormatType"": ""Act"",
                      ""COPVersionDatas"": [],
                      ""COPReferences"": [],
                      ""Id"": 0
                    },
                    {
                      ""SectionNumber"": ""g"",
                      ""Description"": ""that the Authority is notified and provided with a report analysing the cause and the ensuing outcome of any serious adverse event or serious adverse reaction."",
                      ""FormatType"": ""Act"",
                      ""COPVersionDatas"": [],
                      ""COPReferences"": [],
                      ""Id"": 0
                    }
                  ],
                  ""Id"": 0
                },
                {
                  ""SectionNumber"": ""2"",
                  ""Description"": ""References in this Act to the persons to whom a licence applies are to -"",
                  ""FormatType"": ""Act"",
                  ""COPVersionDatas"": [],
                  ""COPReferences"": [
                    {
                      ""SectionNumber"": ""a"",
                      ""Description"": ""the person responsible,"",
                      ""FormatType"": ""Act"",
                      ""COPVersionDatas"": [],
                      ""COPReferences"": [],
                      ""Id"": 0
                    },
                    {
                      ""SectionNumber"": ""b"",
                      ""Description"": ""any person designated in the licence, or in a notice given to the Authority by the person who holds the licence or the person responsible, as a person to whom the licence applies, and"",
                      ""FormatType"": ""Act"",
                      ""COPVersionDatas"": [],
                      ""COPReferences"": [],
                      ""Id"": 0
                    },
                    {
                      ""SectionNumber"": ""c"",
                      ""Description"": ""any person acting under the direction of the person responsible or of any person so designated."",
                      ""FormatType"": ""Act"",
                      ""COPVersionDatas"": [],
                      ""COPReferences"": [],
                      ""Id"": 0
                    }
                  ],
                  ""Id"": 0
                }
              ],
              ""Id"": 0
            }
          ],
          ""Id"": 0
        }
      ],
      ""coplicenceconditions"": [
        {
          ""SectionNumber"": ""T7"",
          ""Description"": ""Where the PR is unable to carry out their duties, whether permanently or temporarily, (eg, where the PR is suspended pending investigation or is on extended sick leave) the holder of the licence must inform the Authority immediately and apply to the Authority for a licence variation to nominate a substitute PR. This nominated substitute PR must not commence their post unless and until the Authority decides that they are suitable."",
          ""FormatType"": ""LicenceCondition"",
          ""COPVersionDatas"": [],
          ""COPReferences"": [],
          ""Id"": 0
        },
        {
          ""SectionNumber"": ""T8"",
          ""Description"": ""The PR must have successfully completed the Authority’s PR Entry Programme."",
          ""FormatType"": ""LicenceCondition"",
          ""COPVersionDatas"": [],
          ""COPReferences"": [],
          ""Id"": 0
        },
        {
          ""SectionNumber"": ""T9"",
          ""Description"": ""The PR must have responsibility for:"",
          ""FormatType"": ""LicenceCondition"",
          ""COPVersionDatas"": [],
          ""COPReferences"": [
            {
              ""SectionNumber"": ""a"",
              ""Description"": ""ensuring the requirements imposed by section 31ZD of the Human Fertilisation and Embryology Act 1990 (as amended), in relation to the provision of information to donors about resulting children, are complied with"",
              ""FormatType"": ""LicenceCondition"",
              ""COPVersionDatas"": [],
              ""COPReferences"": [],
              ""Id"": 0
            },
            {
              ""SectionNumber"": ""b"",
              ""Description"": ""ensuring that the activities are carried out on suitable premises"",
              ""FormatType"": ""LicenceCondition"",
              ""COPVersionDatas"": [],
              ""COPReferences"": [],
              ""Id"": 0
            },
            {
              ""SectionNumber"": ""c"",
              ""Description"": ""ensuring the centre’s staff co-operate fully with inspections and investigations by the Authority or other agencies responsible for law enforcement or regulation of healthcare"",
              ""FormatType"": ""LicenceCondition"",
              ""COPVersionDatas"": [],
              ""COPReferences"": [],
              ""Id"": 0
            },
            {
              ""SectionNumber"": ""d"",
              ""Description"": ""ensuring fees are paid to the Authority within the timescale specified in Directions or in writing"",
              ""FormatType"": ""LicenceCondition"",
              ""COPVersionDatas"": [],
              ""COPReferences"": [],
              ""Id"": 0
            },
            {
              ""SectionNumber"": ""e"",
              ""Description"": ""ensuring data provided to the Authority about activities and data, which the Authority is required to hold on its Register of Information, is accurate and provided by dates specified in Directions or in writing"",
              ""FormatType"": ""LicenceCondition"",
              ""COPVersionDatas"": [],
              ""COPReferences"": [],
              ""Id"": 0
            },
            {
              ""SectionNumber"": ""f"",
              ""Description"": ""ensuring requests for information and/or documents from the Authority are responded to promptly, and"",
              ""FormatType"": ""LicenceCondition"",
              ""COPVersionDatas"": [],
              ""COPReferences"": [],
              ""Id"": 0
            },
            {
              ""SectionNumber"": ""g"",
              ""Description"": ""notifying the Authority immediately if s/he becomes aware of any decision or proposal to close their centre."",
              ""FormatType"": ""LicenceCondition"",
              ""COPVersionDatas"": [],
              ""COPReferences"": [],
              ""Id"": 0
            }
          ],
          ""Id"": 0
        },
        {
          ""SectionNumber"": ""T10"",
          ""Description"": ""In the event of termination of activities, for whatever reason, the PR must ensure that all stored gametes, embryos or admixed embryos are transferred to another licensed centre or centres. The PR must ensure that all relevant information including traceability data and information concerning the quality and safety of gametes and embryos, is transferred with any stored gametes, embryos or admixed embryos, or that records containing this information are made accessible as required."",
          ""FormatType"": ""LicenceCondition"",
          ""COPVersionDatas"": [],
          ""COPReferences"": [],
          ""Id"": 0
        },
        {
          ""SectionNumber"": ""0008"",
          ""Description"": ""Information to be submitted to the HFEA as part of the licensing process"",
          ""FormatType"": ""Direction"",
          ""COPVersionDatas"": [],
          ""COPReferences"": [],
          ""Id"": 0
        }
      ],
      ""copdirections"": [],
      ""copregulatoryprinciples"": [],
      ""copversiondatas"": [
        {
          ""SectionNumber"": """",
          ""Description"": ""Appointing the person responsible"",
          ""FormatType"": ""HeaderGroup"",
          ""COPVersionDatas"": [
            {
              ""SectionNumber"": ""1A"",
              ""Description"": ""Interpretation of mandatory requirements\r\n\r\nThe law requires licensable activity to take place only under the supervision of the ‘person responsible’, as named on the centre’s licence.\r\n\r\nAn individual can be appointed as the person responsible only with the approval of the HFEA. That person must complete the Persons Responsible Entry Programme (PREP) assessment before the HFEA can consider whether or not to approve them."",
              ""FormatType"": ""Interpretation"",
              ""COPVersionDatas"": [],
              ""COPReferences"": [],
              ""Id"": 0
            }
          ],
          ""COPReferences"": [],
          ""Id"": 0
        },
        {
          ""SectionNumber"": """",
          ""Description"": ""The licence holder and the person responsible"",
          ""FormatType"": ""HeaderGroup"",
          ""COPVersionDatas"": [
            {
              ""SectionNumber"": ""1.1"",
              ""Description"": ""The licence holder and the person responsible should be separate individuals. Clinics operating within a hospital or other healthcare organisation may find it advantageous for a senior hospital manager to hold the post of licence holder."",
              ""FormatType"": ""CodeOfPractice"",
              ""COPVersionDatas"": [],
              ""COPReferences"": [],
              ""Id"": 0
            },
            {
              ""SectionNumber"": ""1.2"",
              ""Description"": ""It is the responsibility of the licence holder to inform the HFEA if the person responsible is unable to perform their duties. Where the centre no longer has a person responsible, the licence holder should seek the advice of the HFEA as soon as possible on continuing to provide licensable activities. Either the person responsible or the licence holder may apply for a licence or for its variation or revocation. However, only the licence holder may apply to a licence committee to vary a licence in order to designate another individual to be the person responsible."",
              ""FormatType"": ""CodeOfPractice"",
              ""COPVersionDatas"": [],
              ""COPReferences"": [],
              ""Id"": 0
            }
          ],
          ""COPReferences"": [],
          ""Id"": 0
        },
        {
          ""SectionNumber"": """",
          ""Description"": ""Qualifications for the role of the person responsible"",
          ""FormatType"": ""HeaderGroup"",
          ""COPVersionDatas"": [
            {
              ""SectionNumber"": ""1.3"",
              ""Description"": ""The person responsible should have enough understanding of the scientific, medical, legal, social, ethical and other aspects of the centre’s work to be able to supervise its activities properly. It is also important that the person responsible possesses integrity, and managerial authority and capability."",
              ""FormatType"": ""CodeOfPractice"",
              ""COPVersionDatas"": [],
              ""COPReferences"": [],
              ""Id"": 0
            },
            {
              ""SectionNumber"": ""1.4"",
              ""Description"": ""The HFEA expects the person responsible to take any necessary specialist advice to allow them to run the centre professionally."",
              ""FormatType"": ""CodeOfPractice"",
              ""COPVersionDatas"": [],
              ""COPReferences"": [],
              ""Id"": 0
            }
          ],
          ""COPReferences"": [],
          ""Id"": 0
        },
        {
          ""SectionNumber"": """",
          ""Description"": ""Responsibilities of the person responsible"",
          ""FormatType"": ""HeaderGroup"",
          ""COPVersionDatas"": [
            {
              ""SectionNumber"": ""1.5"",
              ""Description"": ""The role of the person responsible should include:"",
              ""FormatType"": ""CodeOfPractice"",
              ""COPVersionDatas"": [
                {
                  ""SectionNumber"": ""a"",
                  ""Description"": ""maintaining an up-to-date awareness and understanding of legal obligations"",
                  ""FormatType"": ""CodeOfPractice"",
                  ""COPVersionDatas"": [],
                  ""COPReferences"": [],
                  ""Id"": 0
                },
                {
                  ""SectionNumber"": ""b"",
                  ""Description"": ""responding promptly to requests for information and documents from the HFEA"",
                  ""FormatType"": ""CodeOfPractice"",
                  ""COPVersionDatas"": [],
                  ""COPReferences"": [],
                  ""Id"": 0
                },
                {
                  ""SectionNumber"": ""c"",
                  ""Description"": ""co-operating fully with inspections and investigations by the HFEA or other agencies responsible for law enforcement, regulation or healthcare, and"",
                  ""FormatType"": ""CodeOfPractice"",
                  ""COPVersionDatas"": [],
                  ""COPReferences"": [],
                  ""Id"": 0
                },
                {
                  ""SectionNumber"": ""d"",
                  ""Description"": ""informing the HFEA of any change to their professional registration."",
                  ""FormatType"": ""CodeOfPractice"",
                  ""COPVersionDatas"": [],
                  ""COPReferences"": [],
                  ""Id"": 0
                }
              ],
              ""COPReferences"": [],
              ""Id"": 0
            },
            {
              ""SectionNumber"": ""1B"",
              ""Description"": ""Interpretation of mandatory requirements\r\n\r\nThe person responsible is ultimately responsible for ensuring that all licensed activities are conducted with proper regard for the regulatory framework that governs treatment and research involving gametes or embryos."",
              ""FormatType"": ""Interpretation"",
              ""COPVersionDatas"": [],
              ""COPReferences"": [],
              ""Id"": 0
            }
          ],
          ""COPReferences"": [],
          ""Id"": 0
        }
      ],
      ""commaseparatedsearchtags"": """"
    }
  ]
}      
";

        private static string data3 = @"
{
  ""description"": ""8th Edition"",
  ""copgroups"": [],
  ""copsections"": [
    {
      ""sectionumber"": ""3"",
      ""sectioname"": ""Councelling"",
      ""copacts"": [
        {
          ""SectionNumber"": ""Act"",
          ""Description"": ""Human Fertilisation and Embryology Act 2008"",
          ""FormatType"": ""Act"",
          ""COPVersionDatas"": [],
          ""COPReferences"": [
            {
              ""SectionNumber"": ""1"",
              ""Description"": ""Meaning of \""embryo\"",\""gamete\"" and associated expressions"",
              ""FormatType"": ""Act"",
              ""COPVersionDatas"": [],
              ""COPReferences"": [
                {
                  ""SectionNumber"": ""1A"",
                  ""Description"": ""Reference to Directives"",
                  ""FormatType"": ""Act"",
                  ""COPVersionDatas"": [],
                  ""COPReferences"": [
                    {
                      ""SectionNumber"": """",
                      ""Description"": ""In this Act - "",
                      ""FormatType"": ""Act"",
                      ""COPVersionDatas"": [],
                      ""COPReferences"": [],
                      ""Id"": 0
                    }
                  ],
                  ""Id"": 0
                }
              ],
              ""Id"": 0
            },
            {
              ""SectionNumber"": ""8"",
              ""Description"": ""General functions of Authority"",
              ""FormatType"": ""Act"",
              ""COPVersionDatas"": [],
              ""COPReferences"": [
                {
                  ""SectionNumber"": ""8B"",
                  ""Description"": ""Agency arrangements and provision of services"",
                  ""FormatType"": ""Act"",
                  ""COPVersionDatas"": [],
                  ""COPReferences"": [],
                  ""Id"": 0
                }
              ],
              ""Id"": 0
            }
          ],
          ""Id"": 0
        }
      ],
      ""coplicenceconditions"": [
        {
          ""SectionNumber"": ""T9"",
          ""Description"": ""The PR must have responsibility for:"",
          ""FormatType"": ""LicenceCondition"",
          ""COPVersionDatas"": [],
          ""COPReferences"": [
            {
              ""SectionNumber"": ""d"",
              ""Description"": ""ensuring fees are paid to the Authority within the timescale specified in Directions or in writing"",
              ""FormatType"": ""LicenceCondition"",
              ""COPVersionDatas"": [],
              ""COPReferences"": [],
              ""Id"": 0
            },
            {
              ""SectionNumber"": ""f"",
              ""Description"": ""ensuring requests for information and/or documents from the Authority are responded to promptly, and"",
              ""FormatType"": ""LicenceCondition"",
              ""COPVersionDatas"": [],
              ""COPReferences"": [],
              ""Id"": 0
            }
          ],
          ""Id"": 0
        }
      ],
      ""copdirections"": [],
      ""copregulatoryprinciples"": [],
      ""copversiondatas"": [],
      ""commaseparatedsearchtags"": """"
    }
  ]
}


";
    }
}
