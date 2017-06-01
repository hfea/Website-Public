using HFEA.Connector.Contracts.COP;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.Test.COP.Data
{
    public class Section
    {
        public static COPItem Data
        {
            get
            {
                return JsonConvert.DeserializeObject<COPItem>(data);
            }
        }

        private const string data = @"
{
  ""description"": ""8th Edition"",
  ""copgroups"": [],
  ""copsections"": [
    {
      ""sectionumber"": ""2"",
      ""sectioname"": ""Staff"",
      ""copacts"": [
        {
          ""Id"": 1549,
          ""SectionNumber"": ""Act"",
          ""Description"": ""Human Fertilisation and Embryology Act 2008"",
          ""FormatType"": ""Act"",
          ""Url"": null,
          ""COPVersionDatas"": [],
          ""COPReferences"": [
            {
              ""Id"": 1550,
              ""SectionNumber"": ""17"",
              ""Description"": ""The person responsible"",
              ""FormatType"": ""Act"",
              ""Url"": null,
              ""COPVersionDatas"": [],
              ""COPReferences"": [
                {
                  ""Id"": 1551,
                  ""SectionNumber"": ""1"",
                  ""Description"": ""It shall be the duty of the individual under whose supervision the activities authorised by a licence are carried on (referred to in this Act as the \""person responsible\"") to secure -"",
                  ""FormatType"": ""Act"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": [
                    {
                      ""Id"": 1552,
                      ""SectionNumber"": ""a"",
                      ""Description"": ""that the other persons to whom the licence applies are of such character, and are so qualified by training and experience, as to be suitable persons to participate in the activities authorised by the licence,"",
                      ""FormatType"": ""Act"",
                      ""Url"": null,
                      ""COPVersionDatas"": [],
                      ""COPReferences"": []
                    }
                  ]
                }
              ]
            }
          ]
        },
        {
          ""Id"": 1553,
          ""SectionNumber"": ""Schedule 3A"",
          ""Description"": ""Supplementary licence conditions: human application"",
          ""FormatType"": ""Act"",
          ""Url"": null,
          ""COPVersionDatas"": [],
          ""COPReferences"": [
            {
              ""Id"": 1554,
              ""SectionNumber"": ""5"",
              ""Description"": ""Licence conditions shall require all persons to whom a licence applies who are authorised to procure gametes or embryos, or both, to comply with the requirements (including as to staff training, written agreements with staff, standard operating procedures, and appropriate facilities and equipment) laid down in Article 2 (requirements for the procurement of human tissues and cells) of the second Directive."",
              ""FormatType"": ""Act"",
              ""Url"": null,
              ""COPVersionDatas"": [],
              ""COPReferences"": []
            }
          ]
        }
      ],
      ""coplicenceconditions"": [
        {
          ""Id"": 160,
          ""SectionNumber"": ""T11"",
          ""Description"": ""The centre must have an organisational chart which clearly defines accountability and reporting relationships. "",
          ""FormatType"": ""LicenceCondition"",
          ""Url"": null,
          ""COPVersionDatas"": [],
          ""COPReferences"": []
        },
        {
          ""Id"": 161,
          ""SectionNumber"": ""T12"",
          ""Description"": ""Personnel in the centre must be available in sufficient number and be qualified and competent for the tasks they perform. The competency of the personnel must be evaluated at appropriate intervals. "",
          ""FormatType"": ""LicenceCondition"",
          ""Url"": null,
          ""COPVersionDatas"": [],
          ""COPReferences"": []
        },
        {
          ""Id"": 162,
          ""SectionNumber"": ""T13"",
          ""Description"": ""All personnel must have job descriptions that accurately reflect their tasks, and responsibilities. "",
          ""FormatType"": ""LicenceCondition"",
          ""Url"": null,
          ""COPVersionDatas"": [],
          ""COPReferences"": []
        },
        {
          ""Id"": 163,
          ""SectionNumber"": ""T14"",
          ""Description"": ""Personnel carrying out licensed activities or other activities carried out for the purposes of providing treatment services that do not require a licence must, where appropriate, be registered in accordance with the appropriate professional and/or statutory bodies, (eg, General Medical Council, Health Professions Council, Nursing and Midwifery Council)."",
          ""FormatType"": ""LicenceCondition"",
          ""Url"": null,
          ""COPVersionDatas"": [],
          ""COPReferences"": []
        },
        {
          ""Id"": 164,
          ""SectionNumber"": ""T15"",
          ""Description"": ""Personnel must be provided with initial/basic training. Training must be updated as required when procedures change or scientific knowledge develops, and adequate opportunity for relevant professional development must be provided. The training programme must ensure and document that each individual:"",
          ""FormatType"": ""LicenceCondition"",
          ""Url"": null,
          ""COPVersionDatas"": [],
          ""COPReferences"": [
            {
              ""Id"": 165,
              ""SectionNumber"": ""a"",
              ""Description"": ""has demonstrated competence in the performance of their designated  tasks"",
              ""FormatType"": ""LicenceCondition"",
              ""Url"": null,
              ""COPVersionDatas"": [],
              ""COPReferences"": []
            },
            {
              ""Id"": 166,
              ""SectionNumber"": ""b"",
              ""Description"": ""has an adequate knowledge and understanding of the scientific/technical processes and principles relevant to their designated tasks"",
              ""FormatType"": ""LicenceCondition"",
              ""Url"": null,
              ""COPVersionDatas"": [],
              ""COPReferences"": []
            },
            {
              ""Id"": 167,
              ""SectionNumber"": ""c"",
              ""Description"": ""understands the organisational framework, quality system and Health & Safety rules of the centre in which they work, and"",
              ""FormatType"": ""LicenceCondition"",
              ""Url"": null,
              ""COPVersionDatas"": [],
              ""COPReferences"": []
            },
            {
              ""Id"": 168,
              ""SectionNumber"": ""d"",
              ""Description"": ""is adequately informed of the broader ethical, legal and regulatory context of their work."",
              ""FormatType"": ""LicenceCondition"",
              ""Url"": null,
              ""COPVersionDatas"": [],
              ""COPReferences"": []
            }
          ]
        },
        {
          ""Id"": 169,
          ""SectionNumber"": ""T16"",
          ""Description"": ""The centre must have access to a nominated registered medical practitioner, within the UK, to advise on and oversee medical activities. "",
          ""FormatType"": ""LicenceCondition"",
          ""Url"": null,
          ""COPVersionDatas"": [],
          ""COPReferences"": []
        }
      ],
      ""copdirections"": [],
      ""copregulatoryprinciples"": [
        {
          ""Id"": 1570,
          ""SectionNumber"": ""2"",
          ""Description"": ""have proper respect for the privacy, confidentiality, dignity, comfort and well being of patients and donors"",
          ""FormatType"": ""Principle"",
          ""Url"": null,
          ""COPVersionDatas"": [],
          ""COPReferences"": []
        },
        {
          ""Id"": 1571,
          ""SectionNumber"": ""7"",
          ""Description"": ""conduct all licensed activities with proper skill and care and in an appropriate environment, in accordance with good clinical practice, to ensure optimum outcomes and minimum risk for patients, donors and offspring"",
          ""FormatType"": ""Principle"",
          ""Url"": null,
          ""COPVersionDatas"": [],
          ""COPReferences"": []
        },
        {
          ""Id"": 1572,
          ""SectionNumber"": ""9"",
          ""Description"": ""ensure that all staff engaged in licensed activity are competent and recruited in sufficient numbers to guarantee safe clinical and laboratory practice;"",
          ""FormatType"": ""Principle"",
          ""Url"": null,
          ""COPVersionDatas"": [],
          ""COPReferences"": []
        }
      ],
      ""copversiondatas"": [
        {
          ""Id"": 722,
          ""SectionNumber"": "" "",
          ""Description"": ""Centre Staff"",
          ""FormatType"": ""CodeOfPractice"",
          ""Url"": null,
          ""COPVersionDatas"": [
            {
              ""Id"": 723,
              ""SectionNumber"": ""2.1"",
              ""Description"": ""The centre should establish documented procedures for staff management that ensure all staff have: \r\n"",
              ""FormatType"": ""CodeOfPractice"",
              ""Url"": null,
              ""COPVersionDatas"": [
                {
                  ""Id"": 724,
                  ""SectionNumber"": ""a"",
                  ""Description"": ""initial basic training and updated training as required"",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                },
                {
                  ""Id"": 725,
                  ""SectionNumber"": ""b"",
                  ""Description"": ""on-going competence assessment, with audits of this assessment"",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                },
                {
                  ""Id"": 726,
                  ""SectionNumber"": ""c"",
                  ""Description"": ""an annual joint review (with their line manager)"",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                },
                {
                  ""Id"": 727,
                  ""SectionNumber"": ""d"",
                  ""Description"": ""continuing education and professional development"",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                },
                {
                  ""Id"": 728,
                  ""SectionNumber"": ""e"",
                  ""Description"": ""staff records, and"",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                },
                {
                  ""Id"": 729,
                  ""SectionNumber"": ""f"",
                  ""Description"": ""appropriate access to meetings and communications. "",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                }
              ],
              ""COPReferences"": []
            },
            {
              ""Id"": 730,
              ""SectionNumber"": ""2.2"",
              ""Description"": ""Staff records should include: \r\n"",
              ""FormatType"": ""CodeOfPractice"",
              ""Url"": null,
              ""COPVersionDatas"": [
                {
                  ""Id"": 743,
                  ""SectionNumber"": """",
                  ""Description"": ""The centre should ensure that confidentiality of staff records is in line with best practice and relevant legislation. "",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                },
                {
                  ""Id"": 731,
                  ""SectionNumber"": ""a"",
                  ""Description"": ""job description"",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                },
                {
                  ""Id"": 732,
                  ""SectionNumber"": ""b"",
                  ""Description"": ""terms and conditions of employment"",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                },
                {
                  ""Id"": 733,
                  ""SectionNumber"": ""c"",
                  ""Description"": ""a record of staff induction and orientation"",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                },
                {
                  ""Id"": 734,
                  ""SectionNumber"": ""d"",
                  ""Description"": ""a record of health and safety training"",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                },
                {
                  ""Id"": 735,
                  ""SectionNumber"": ""e"",
                  ""Description"": ""a record of education and training, including continuing professional development "",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                },
                {
                  ""Id"": 736,
                  ""SectionNumber"": ""f"",
                  ""Description"": ""relevant educational and professional qualifications"",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                },
                {
                  ""Id"": 737,
                  ""SectionNumber"": ""g"",
                  ""Description"": ""certificate of registration, if relevant\r\n("",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                },
                {
                  ""Id"": 738,
                  ""SectionNumber"": ""h"",
                  ""Description"": ""absence record"",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                },
                {
                  ""Id"": 739,
                  ""SectionNumber"": ""i"",
                  ""Description"": ""accident record"",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                },
                {
                  ""Id"": 740,
                  ""SectionNumber"": ""j"",
                  ""Description"": ""a record of annual joint reviews"",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                },
                {
                  ""Id"": 741,
                  ""SectionNumber"": ""k"",
                  ""Description"": ""occupational health record, and"",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                },
                {
                  ""Id"": 742,
                  ""SectionNumber"": ""l"",
                  ""Description"": ""a record of any disciplinary action."",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                }
              ],
              ""COPReferences"": []
            },
            {
              ""Id"": 744,
              ""SectionNumber"": ""2.3"",
              ""Description"": ""l staff should participate in an annual joint review that examines the needs of the centre and of the individual to improve the quality of the service to users and to encourage productive working relationships. Staff performing annual reviews must receive appropriate training."",
              ""FormatType"": ""CodeOfPractice"",
              ""Url"": null,
              ""COPVersionDatas"": [],
              ""COPReferences"": []
            },
            {
              ""Id"": 745,
              ""SectionNumber"": ""2.4"",
              ""Description"": ""The centre should have an effective way of communicating information to, and receiving suggestions from, staff. Centre management should also ensure that the accountabilities and reporting relationships shown in the centre’s organisational chart are communicated within the centre. "",
              ""FormatType"": ""CodeOfPractice"",
              ""Url"": null,
              ""COPVersionDatas"": [],
              ""COPReferences"": []
            },
            {
              ""Id"": 746,
              ""SectionNumber"": ""2.5"",
              ""Description"": ""Centre management should ensure that staff members who are in contact with patients and donors"",
              ""FormatType"": ""CodeOfPractice"",
              ""Url"": null,
              ""COPVersionDatas"": [
                {
                  ""Id"": 747,
                  ""SectionNumber"": ""a"",
                  ""Description"": ""are prepared to offer appropriate emotional support to people suffering distress at any stage of their investigation, counselling or treatment"",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                },
                {
                  ""Id"": 748,
                  ""SectionNumber"": ""b"",
                  ""Description"": ""understand and can explain the role of counselling, and"",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                },
                {
                  ""Id"": 749,
                  ""SectionNumber"": ""c"",
                  ""Description"": ""know when and how to refer people to the centre’s qualified counsellor. "",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                }
              ],
              ""COPReferences"": []
            },
            {
              ""Id"": 750,
              ""SectionNumber"": ""2.6"",
              ""Description"": ""Centres should require all prospective and existing staff to report promptly all criminal convictions they have had to the person responsible. In deciding whether or not an individual shall take part in a licensed activity at the centre, the person responsible should take into account relevant previous convictions and breaches of regulations."",
              ""FormatType"": ""CodeOfPractice"",
              ""Url"": null,
              ""COPVersionDatas"": [],
              ""COPReferences"": []
            }
          ],
          ""COPReferences"": []
        },
        {
          ""Id"": 751,
          ""SectionNumber"": null,
          ""Description"": ""Medical staff"",
          ""FormatType"": ""CodeOfPractice"",
          ""Url"": null,
          ""COPVersionDatas"": [
            {
              ""Id"": 752,
              ""SectionNumber"": ""2.7"",
              ""Description"": ""The person responsible should ensure that staff who must be registered with professional bodies are registered, their registration is up to date, and records of this are kept."",
              ""FormatType"": ""CodeOfPractice"",
              ""Url"": null,
              ""COPVersionDatas"": [],
              ""COPReferences"": []
            },
            {
              ""Id"": 753,
              ""SectionNumber"": ""2.8"",
              ""Description"": ""The individual with overall clinical responsibility for treatment services involving in vitro fertilisation should"",
              ""FormatType"": ""CodeOfPractice"",
              ""Url"": null,
              ""COPVersionDatas"": [
                {
                  ""Id"": 754,
                  ""SectionNumber"": ""a"",
                  ""Description"": ""have completed training recognised by the Royal College of Obstetricians and Gynaecologists (or an equivalent professional body) "",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                },
                {
                  ""Id"": 755,
                  ""SectionNumber"": ""b"",
                  ""Description"": ""be on the General Medical Council’s Specialist Register, and "",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                },
                {
                  ""Id"": 756,
                  ""SectionNumber"": ""c"",
                  ""Description"": ""participate in a recognised programme of continuing medical education and professional development."",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                }
              ],
              ""COPReferences"": []
            },
            {
              ""Id"": 757,
              ""SectionNumber"": ""2.9"",
              ""Description"": ""If the centre is licensed to provide insemination services only, the individual with overall clinical responsibility should:"",
              ""FormatType"": ""CodeOfPractice"",
              ""Url"": null,
              ""COPVersionDatas"": [
                {
                  ""Id"": 758,
                  ""SectionNumber"": ""a"",
                  ""Description"": ""be a registered medical practitioner, and"",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                },
                {
                  ""Id"": 759,
                  ""SectionNumber"": ""b"",
                  ""Description"": ""have sufficient experience in an established fertility centre to be qualified  to take full charge of the centre’s treatment services."",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                }
              ],
              ""COPReferences"": []
            },
            {
              ""Id"": 760,
              ""SectionNumber"": ""2.10"",
              ""Description"": ""Other medical staff who take part in providing treatment services should be registered medical practitioners with sufficient experience under supervision to qualify them to do so. Medical staff who do laparoscopies should be Fellows or Members of the Royal College of Obstetricians and Gynaecologists (or an equivalent professional body). Medical staff in training should follow relevant training programmes under appropriate supervision."",
              ""FormatType"": ""HeaderGroup"",
              ""Url"": null,
              ""COPVersionDatas"": [],
              ""COPReferences"": []
            }
          ],
          ""COPReferences"": []
        },
        {
          ""Id"": 761,
          ""SectionNumber"": null,
          ""Description"": ""Nursing staff"",
          ""FormatType"": ""CodeOfPractice"",
          ""Url"": null,
          ""COPVersionDatas"": [
            {
              ""Id"": 1057,
              ""SectionNumber"": ""2.11"",
              ""Description"": ""Nurses should be:"",
              ""FormatType"": ""CodeOfPractice"",
              ""Url"": null,
              ""COPVersionDatas"": [
                {
                  ""Id"": 1058,
                  ""SectionNumber"": ""a"",
                  ""Description"": ""working towards competencies set nationally, locally or both, to ensure appropriate standards of clinical competence, and"",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                },
                {
                  ""Id"": 1059,
                  ""SectionNumber"": ""b"",
                  ""Description"": ""able to provide evidence of competence in the duties performed (for example, a certificate for a recognised qualification or a written testimonial by another person who is suitably qualified and competent in that discipline or function)."",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                }
              ],
              ""COPReferences"": []
            },
            {
              ""Id"": 762,
              ""SectionNumber"": ""2A"",
              ""Description"": ""Interpretation of mandatory requirements\r\n\r\nAll nursing staff must be appropriately qualified and registered by the Nursing and Midwifery Council."",
              ""FormatType"": ""Interpretation"",
              ""Url"": null,
              ""COPVersionDatas"": [],
              ""COPReferences"": []
            }
          ],
          ""COPReferences"": []
        },
        {
          ""Id"": 1060,
          ""SectionNumber"": """",
          ""Description"": ""Counselling staff"",
          ""FormatType"": ""CodeOfPractice"",
          ""Url"": null,
          ""COPVersionDatas"": [
            {
              ""Id"": 1061,
              ""SectionNumber"": ""2.12"",
              ""Description"": ""Treatment centres should ensure that at least one individual is appointed to fulfil the role of counsellor. All counsellors should have specialist competence in infertility counselling and:"",
              ""FormatType"": ""CodeOfPractice"",
              ""Url"": null,
              ""COPVersionDatas"": [
                {
                  ""Id"": 1062,
                  ""SectionNumber"": ""a"",
                  ""Description"": ""hold a recognised counselling, clinical psychology, counselling psychology or psychotherapy qualification to the level of diploma of higher education or above, and"",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                },
                {
                  ""Id"": 1063,
                  ""SectionNumber"": ""b"",
                  ""Description"": ""be accredited under the scheme of the British Infertility Counselling Association (or an equivalent body), or show evidence of working towards such accreditation"",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                }
              ],
              ""COPReferences"": []
            },
            {
              ""Id"": 1064,
              ""SectionNumber"": ""2.13"",
              ""Description"": ""A member of staff appointed to the role of counsellor should be able to provide evidence of being an accredited member of, or working towards accredited membership of, a recognised professional counselling body. The body should have with a complaints/disciplinary procedure , and the individual should have agreed to abide by an appropriate code of conduct or ethics."",
              ""FormatType"": ""CodeOfPractice"",
              ""Url"": null,
              ""COPVersionDatas"": [],
              ""COPReferences"": []
            },
            {
              ""Id"": 1065,
              ""SectionNumber"": ""2.14"",
              ""Description"": ""Treatment centres carrying out pre-implantation genetic diagnosis or mitochondrial donation should ensure that patients have access to counsellors with appropriate knowledge and expertise in these specialisms, including the risks and implications of mitochondrial donation techniques."",
              ""FormatType"": ""CodeOfPractice"",
              ""Url"": null,
              ""COPVersionDatas"": [],
              ""COPReferences"": []
            }
          ],
          ""COPReferences"": [
            {
              ""Id"": 1573,
              ""SectionNumber"": ""3"",
              ""Description"": ""Councelling"",
              ""FormatType"": ""ReferenceCOP"",
              ""Url"": null,
              ""COPVersionDatas"": [],
              ""COPReferences"": []
            }
          ]
        },
        {
          ""Id"": 1066,
          ""SectionNumber"": """",
          ""Description"": ""Staff engaged in scientific services"",
          ""FormatType"": ""CodeOfPractice"",
          ""Url"": null,
          ""COPVersionDatas"": [
            {
              ""Id"": 1067,
              ""SectionNumber"": ""2.15"",
              ""Description"": ""Centre management should ensure that the centre has access to a nominated registered scientist to advise on and oversee scientific activities."",
              ""FormatType"": ""CodeOfPractice"",
              ""Url"": null,
              ""COPVersionDatas"": [],
              ""COPReferences"": []
            },
            {
              ""Id"": 1068,
              ""SectionNumber"": ""2.16"",
              ""Description"": ""All healthcare scientists working in licensed centres should be registered or show evidence of working towards registration with the Health & Care Professions Council (HCPC), or other equivalent body where applicable. It is expected that all staff should be registered with the HCPC (or other equivalent body) within one year of their becoming eligible, including those eligible as international applicants after training overseas."",
              ""FormatType"": ""CodeOfPractice"",
              ""Url"": null,
              ""COPVersionDatas"": [],
              ""COPReferences"": []
            },
            {
              ""Id"": 1069,
              ""SectionNumber"": ""2.17"",
              ""Description"": ""Healthcare scientists from overseas who are registered in their own country but working in a licensed centre as a visiting scientist, should seek temporary registration with the HCPC (or other equivalent body)."",
              ""FormatType"": ""CodeOfPractice"",
              ""Url"": null,
              ""COPVersionDatas"": [],
              ""COPReferences"": []
            },
            {
              ""Id"": 1070,
              ""SectionNumber"": ""2.18"",
              ""Description"": ""Healthcare scientists employed in roles not yet requiring state registration (eg, aspirant groups, healthcare science assistants and healthcare science practitioners) should follow an appropriate induction and training programme for the tasks performed. Each individual should maintain proper records of this training."",
              ""FormatType"": ""CodeOfPractice"",
              ""Url"": null,
              ""COPVersionDatas"": [],
              ""COPReferences"": []
            },
            {
              ""Id"": 1071,
              ""SectionNumber"": ""2.19"",
              ""Description"": ""The individual responsible for the seminology laboratory should:"",
              ""FormatType"": ""CodeOfPractice"",
              ""Url"": null,
              ""COPVersionDatas"": [
                {
                  ""Id"": 1072,
                  ""SectionNumber"": ""a"",
                  ""Description"": ""possess a degree or higher national diploma in a relevant discipline"",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                },
                {
                  ""Id"": 1073,
                  ""SectionNumber"": ""b"",
                  ""Description"": ""have acquired sufficient experience in such a laboratory to supervise and be responsible for one, and"",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                },
                {
                  ""Id"": 1074,
                  ""SectionNumber"": ""c"",
                  ""Description"": ""be registered with the HCPC as a clinical scientist or biomedical scientist, or be able to demonstrate equivalent training or expertise."",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                }
              ],
              ""COPReferences"": [
                {
                  ""Id"": 587,
                  ""SectionNumber"": """",
                  ""Description"": ""Association of Biomedical Andrologists – Guidelines for Good Practice"",
                  ""FormatType"": ""ReferenceOther"",
                  ""Url"": ""http://www.aba.uk.net/"",
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                }
              ]
            },
            {
              ""Id"": 1092,
              ""SectionNumber"": ""2.20"",
              ""Description"": ""The individual responsible for the clinical embryology laboratory should:"",
              ""FormatType"": ""CodeOfPractice"",
              ""Url"": null,
              ""COPVersionDatas"": [
                {
                  ""Id"": 1093,
                  ""SectionNumber"": ""a"",
                  ""Description"": ""possess an appropriate scientific or medical degree"",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                },
                {
                  ""Id"": 1094,
                  ""SectionNumber"": ""b"",
                  ""Description"": ""have had sufficient experience in such a laboratory to be able to supervise and be responsible for one, and"",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                },
                {
                  ""Id"": 1095,
                  ""SectionNumber"": ""c"",
                  ""Description"": ""be registered with the HCPC (or other equivalent body) as a clinical scientist with specific expertise in clinical embryology."",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                }
              ],
              ""COPReferences"": [
                {
                  ""Id"": 588,
                  ""SectionNumber"": """",
                  ""Description"": ""Association of Clinical Embryologists - Guidelines for IVF Laboratories Accreditation Standards"",
                  ""FormatType"": ""ReferenceOther"",
                  ""Url"": ""https://www.embryologists.org.uk/"",
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                }
              ]
            }
          ],
          ""COPReferences"": []
        },
        {
          ""Id"": 1096,
          ""SectionNumber"": null,
          ""Description"": ""Competence and training of ICSI and embryo biopsy practitioners and mitochondrial donation practitioners"",
          ""FormatType"": ""CodeOfPractice"",
          ""Url"": null,
          ""COPVersionDatas"": [
            {
              ""Id"": 1097,
              ""SectionNumber"": ""2.21"",
              ""Description"": ""The person responsible should ensure that micromanipulation procedures such as ICSI, embryo biopsy and mitochondrial donation are only carried out by practitioners who have the necessary competence."",
              ""FormatType"": ""CodeOfPractice"",
              ""Url"": null,
              ""COPVersionDatas"": [],
              ""COPReferences"": []
            },
            {
              ""Id"": 1098,
              ""SectionNumber"": ""2.22"",
              ""Description"": ""Following training, the competence of each person performing micromanipulation procedures should be evaluated at intervals specified in the quality management system. Retraining should be given when required."",
              ""FormatType"": ""CodeOfPractice"",
              ""Url"": null,
              ""COPVersionDatas"": [],
              ""COPReferences"": []
            },
            {
              ""Id"": 1099,
              ""SectionNumber"": ""2.23"",
              ""Description"": ""In the case of mitochondrial donation, only the embryologist(s) practitioner(s) who have been designated as competent by a licence committee (‘the designated embryologist(s)’) and named on the clinic’s licence may carry out maternal spindle transfer (MST) and/or pronuclear transfer (PNT). If the clinic wishes to change the designated embryologist or add to the list of designated embryologists, the clinic will need to apply to the Authority to vary its licence"",
              ""FormatType"": ""CodeOfPractice"",
              ""Url"": null,
              ""COPVersionDatas"": [],
              ""COPReferences"": []
            }
          ],
          ""COPReferences"": []
        },
        {
          ""Id"": 1100,
          ""SectionNumber"": null,
          ""Description"": ""Staff involved in genetic testing and mitochondrial donation"",
          ""FormatType"": ""CodeOfPractice"",
          ""Url"": null,
          ""COPVersionDatas"": [
            {
              ""Id"": 1101,
              ""SectionNumber"": ""2.24"",
              ""Description"": ""A senior clinical geneticist or mitochondrial disease expert should be involved in the decision-making process when deciding whether a patient should receive treatment involving embryo testing or mitochondrial donation."",
              ""FormatType"": ""CodeOfPractice"",
              ""Url"": null,
              ""COPVersionDatas"": [],
              ""COPReferences"": []
            },
            {
              ""Id"": 1102,
              ""SectionNumber"": ""2.25"",
              ""Description"": ""The centre should ensure that a multidisciplinary team is involved in providing the service. Where relevant the team should include reproductive specialists, embryologists, clinical geneticists, genetic counsellors, cytogeneticist, molecular geneticists and mitochondrial disease specialists. It should maintain close contact with the primary care physician or the referring clinician"",
              ""FormatType"": ""CodeOfPractice"",
              ""Url"": null,
              ""COPVersionDatas"": [],
              ""COPReferences"": []
            },
            {
              ""Id"": 1103,
              ""SectionNumber"": ""2.25"",
              ""Description"": ""If the centre offers an embryo testing or mitochondrial donation service, the individual responsible for this laboratory should"",
              ""FormatType"": ""CodeOfPractice"",
              ""Url"": null,
              ""COPVersionDatas"": [
                {
                  ""Id"": 1104,
                  ""SectionNumber"": ""a"",
                  ""Description"": ""hold an appropriate scientific or medical degree"",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                },
                {
                  ""Id"": 1105,
                  ""SectionNumber"": ""b"",
                  ""Description"": ""have acquired sufficient experience in an appropriately accredited medical genetics diagnostic laboratory to supervise and be responsible for one, and"",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                },
                {
                  ""Id"": 1106,
                  ""SectionNumber"": ""c"",
                  ""Description"": ""be registered with the HCPC (or other equivalent body) as a clinical scientist with specific expertise in clinical genetics."",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                }
              ],
              ""COPReferences"": []
            },
            {
              ""Id"": 1107,
              ""SectionNumber"": ""2.26"",
              ""Description"": ""If genetic testing of those seeking treatment or considering donation is offered, the centre should ensure that an individual is available who understands the:"",
              ""FormatType"": ""CodeOfPractice"",
              ""Url"": null,
              ""COPVersionDatas"": [
                {
                  ""Id"": 1108,
                  ""SectionNumber"": ""a"",
                  ""Description"": ""nature of the tests conducted"",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                },
                {
                  ""Id"": 1109,
                  ""SectionNumber"": ""b"",
                  ""Description"": ""scope and limitations of the tests"",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                },
                {
                  ""Id"": 1110,
                  ""SectionNumber"": ""c"",
                  ""Description"": ""accuracy and implications of the tests, and"",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                },
                {
                  ""Id"": 1111,
                  ""SectionNumber"": ""d"",
                  ""Description"": ""meaning of the test results."",
                  ""FormatType"": ""CodeOfPractice"",
                  ""Url"": null,
                  ""COPVersionDatas"": [],
                  ""COPReferences"": []
                }
              ],
              ""COPReferences"": []
            },
            {
              ""Id"": 1112,
              ""SectionNumber"": ""2.27"",
              ""Description"": ""The centre should ensure that people seeking treatment have access to clinical geneticists, mitochondrial donation specialists and genetic counsellors where relevant"",
              ""FormatType"": ""CodeOfPractice"",
              ""Url"": null,
              ""COPVersionDatas"": [],
              ""COPReferences"": []
            },
            {
              ""Id"": 1113,
              ""SectionNumber"": ""2.28"",
              ""Description"": ""The centre should work closely with the local genetics or mitochondrial disease team of those seeking treatment."",
              ""FormatType"": ""CodeOfPractice"",
              ""Url"": null,
              ""COPVersionDatas"": [],
              ""COPReferences"": []
            }
          ],
          ""COPReferences"": []
        }
      ],
      ""commaseparatedsearchtags"": """",
      ""copdocument"": {
        ""url"": ""http://azure.hfea.org.uk/file2.pdf"",
        ""title"": ""Test file 2"",
        ""filesize"": 156,
        ""filetype"": 1
        }
    }
  ],
  ""copdocument"": {
    ""url"": ""http://azure.hfea.org.uk/file1.pdf"",
    ""title"": ""Test file 1"",
    ""filesize"": 144,
    ""filetype"": 0
  }
}
";
    }
}
