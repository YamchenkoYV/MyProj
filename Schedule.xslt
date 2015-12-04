<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
  <!--
  <xsl:output method="xml" indent="yes"/>-->
  <xsl:output media-type="text/html" method="html"/>
  <xsl:template match="/schedule/year/semester/day">
    <tr>
      <td colspan="3">
        <table border="1">
          <tr>
    <td rowspan ="7" class="SubCell">
      <xsl:value-of select="@name"/>
    </td>
 
    <td class="SubCell">8:30</td>
            <xsl:call-template name="SubjOfTime">
              <xsl:with-param name="time">8:30</xsl:with-param>
            </xsl:call-template>           
    </tr>
    <tr>
      <td class="SubCell">10:15</td>
      <xsl:call-template name="SubjOfTime">
        <xsl:with-param name="time">10:15</xsl:with-param>
      </xsl:call-template>
    </tr>
    <tr>
      <td class="SubCell">12:00</td>
            <xsl:call-template name="SubjOfTime">
            <xsl:with-param name="time">12:00</xsl:with-param>
            </xsl:call-template> 
    </tr>
    <tr>
      <td class="SubCell">13:50</td>
      <xsl:call-template name="SubjOfTime">
        <xsl:with-param name="time">13:50</xsl:with-param>
      </xsl:call-template>
    </tr>
    <tr>
      <td class="SubCell">15:40</td>
      <xsl:call-template name="SubjOfTime">
        <xsl:with-param name="time">15:40</xsl:with-param>
      </xsl:call-template>
    </tr>
    <tr>
      <td class="SubCell">17:25</td>
      <xsl:call-template name="SubjOfTime">
        <xsl:with-param name="time">17:25</xsl:with-param>
      </xsl:call-template>
    </tr>
    <tr>
      <td class="SubCell">19:10</td>
      <xsl:call-template name="SubjOfTime">
        <xsl:with-param name="time">19:10</xsl:with-param> 
      </xsl:call-template>
    </tr>
          </table>
        </td>
    </tr>
  </xsl:template>
  
  
  
  <xsl:template name="SubjOfTime">
    <xsl:param name ="time"/>
    <td class="Cell">
      <xsl:variable name="x" select="./subject[@time_begin = $time]"/>
      <span>
        <xsl:value-of select="./subject[@time_begin = $time]/@type"/>
      </span> &#160;
      <xsl:value-of select="$x"/>
      <xsl:if test="$x != ''">
        <span>
          ауд.<xsl:value-of select="./subject[@time_begin = $time]/@classroom"/>
        </span>
      </xsl:if>
    </td>
  </xsl:template>
  
  
    <xsl:template match="/">
      <html>
        <head>
          <title>
           Schedule for RK6-12 students
          </title>
          <style type="text/css">
            span {
            font-size:smaller;
            font-weight:lighter;
            }


            td {
            border-spacing:15px;
            text-align:center;
            width:600px;
            }

            .Cell {
            text-align:center;
            width:400px;
            }
            .SubCell {
            text-align:center;
            width:100px;
            }
            th {
            text-align:center;
            background-color:#cccccc;
            }
          </style>
        </head>
        <body>
          <h2 allign="center" >Schedule for RK6-12 students</h2>
          <br/><br/>
          <table border="1" width="800">
            <th>Year</th>
            <th>Semester</th>
            <th class="SubCell">Day</th>
            <th class="SubCell">Time</th>
            <th class="Cell">Subject</th>
            <xsl:for-each select="/schedule/year">              
              <tr>
                <td rowspan="14">
                  <xsl:value-of select="@name"/>
                </td>
                <xsl:for-each select="./semester">
                <td rowspan="7" >
                  Semester <xsl:value-of select="@number"/>
                </td>
                <xsl:apply-templates/>
            </xsl:for-each>
            </tr>
           </xsl:for-each>  
          </table>
        </body>
       </html>
    </xsl:template>
</xsl:stylesheet>
